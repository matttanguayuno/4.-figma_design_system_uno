using System.Text;
using System.Text.Json;

namespace figma_design_system_uno.Presentation;

public partial record FigmaComponentListModel
{
    private readonly IHttpClientFactory _httpClientFactory;

    public FigmaComponentListModel(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public IState<string> FileKey => State<string>.Value(this, () => string.Empty);
    
    public IState<string> AccessToken => State<string>.Value(this, () => string.Empty);
    
    public IState<bool> ShouldFetch => State<bool>.Value(this, () => false);
    
    public IState<string> ComponentList => State<string>.Async(this, GetComponentsAsync);

    public async ValueTask FetchComponents()
    {
        await ShouldFetch.UpdateAsync(_ => true, CancellationToken.None);
    }

    private async ValueTask<string> GetComponentsAsync(CancellationToken ct)
    {
        var shouldFetch = await ShouldFetch;
        if (!shouldFetch)
        {
            return "Click 'Fetch Components' to retrieve the list.";
        }

        var fileKey = await FileKey;
        var token = await AccessToken;

        if (string.IsNullOrWhiteSpace(fileKey) || string.IsNullOrWhiteSpace(token))
        {
            return "Please enter both File Key and Access Token.";
        }

        try
        {
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Add("X-Figma-Token", token);

            var response = await httpClient.GetAsync($"https://api.figma.com/v1/files/{fileKey}", ct);
            
            if (!response.IsSuccessStatusCode)
            {
                return $"Error: {response.StatusCode} - {await response.Content.ReadAsStringAsync(ct)}";
            }

            var content = await response.Content.ReadAsStringAsync(ct);
            var document = JsonDocument.Parse(content);
            
            var components = new StringBuilder();
            components.AppendLine("FIGMA COMPONENTS - Copy this list:");
            components.AppendLine("=====================================");
            components.AppendLine();

            ExtractComponents(document.RootElement, components);

            return components.ToString();
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }

    private void ExtractComponents(JsonElement element, StringBuilder output, string path = "")
    {
        if (element.TryGetProperty("type", out var type))
        {
            var typeValue = type.GetString();
            
            // Look for component-related types
            if (typeValue == "COMPONENT" || typeValue == "COMPONENT_SET")
            {
                var name = element.TryGetProperty("name", out var nameEl) ? nameEl.GetString() : "Unknown";
                var id = element.TryGetProperty("id", out var idEl) ? idEl.GetString() : "Unknown";
                
                output.AppendLine($"Name: {name}");
                output.AppendLine($"Node ID: {id}");
                output.AppendLine($"Type: {typeValue}");
                output.AppendLine("---");
            }
        }

        // Recurse through children
        if (element.TryGetProperty("children", out var children) && children.ValueKind == JsonValueKind.Array)
        {
            foreach (var child in children.EnumerateArray())
            {
                ExtractComponents(child, output, path);
            }
        }

        // Check document property
        if (element.TryGetProperty("document", out var document))
        {
            ExtractComponents(document, output, path);
        }
    }
}
