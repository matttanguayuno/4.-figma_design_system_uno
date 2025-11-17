using Windows.ApplicationModel.DataTransfer;
using System.Reflection;

namespace figma_design_system_uno.Controls;

public sealed partial class SourceCodeViewer : UserControl
{
    public static readonly DependencyProperty PageXamlPathProperty =
        DependencyProperty.Register(
            nameof(PageXamlPath),
            typeof(string),
            typeof(SourceCodeViewer),
            new PropertyMetadata(null, OnPageXamlPathChanged));

    public static readonly DependencyProperty StyleXamlPathProperty =
        DependencyProperty.Register(
            nameof(StyleXamlPath),
            typeof(string),
            typeof(SourceCodeViewer),
            new PropertyMetadata(null, OnStyleXamlPathChanged));

    public string PageXamlPath
    {
        get => (string)GetValue(PageXamlPathProperty);
        set => SetValue(PageXamlPathProperty, value);
    }

    public string StyleXamlPath
    {
        get => (string)GetValue(StyleXamlPathProperty);
        set => SetValue(StyleXamlPathProperty, value);
    }

    private string _pageXamlContent = "";
    private string _styleXamlContent = "";

    public SourceCodeViewer()
    {
        this.InitializeComponent();
        this.Loaded += SourceCodeViewer_Loaded;
    }

    private static void OnPageXamlPathChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is SourceCodeViewer viewer && viewer.IsLoaded)
        {
            _ = viewer.LoadPageXamlAsync();
        }
    }

    private static void OnStyleXamlPathChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is SourceCodeViewer viewer && viewer.IsLoaded)
        {
            _ = viewer.LoadStyleXamlAsync();
        }
    }

    private async void SourceCodeViewer_Loaded(object sender, RoutedEventArgs e)
    {
        await LoadPageXamlAsync();
        await LoadStyleXamlAsync();
    }

    private async Task LoadPageXamlAsync()
    {
        if (string.IsNullOrEmpty(PageXamlPath)) return;

        try
        {
            _pageXamlContent = await LoadEmbeddedResourceAsync(PageXamlPath);
            PageXamlTextBox.Text = _pageXamlContent;
        }
        catch (Exception ex)
        {
            PageXamlTextBox.Text = $"Error loading file: {ex.Message}";
        }
    }

    private async Task LoadStyleXamlAsync()
    {
        if (string.IsNullOrEmpty(StyleXamlPath)) return;

        try
        {
            _styleXamlContent = await LoadEmbeddedResourceAsync(StyleXamlPath);
            StyleXamlTextBox.Text = _styleXamlContent;
        }
        catch (Exception ex)
        {
            StyleXamlTextBox.Text = $"Error loading file: {ex.Message}";
        }
    }

    private async Task<string> LoadEmbeddedResourceAsync(string resourcePath)
    {
        return await Task.Run(() =>
        {
            // Convert ms-appx:///Presentation/AvatarPage.xaml to figma_design_system_uno.Presentation.AvatarPage.xaml
            var path = resourcePath.Replace("ms-appx:///", "").Replace("/", ".");
            var fullResourceName = $"figma_design_system_uno.{path}";
            
            var assembly = Assembly.GetExecutingAssembly();
            
            // Try exact match first
            using var stream = assembly.GetManifestResourceStream(fullResourceName);
            if (stream == null)
            {
                // List all embedded resources for debugging
                var availableResources = assembly.GetManifestResourceNames();
                var matchingResource = availableResources.FirstOrDefault(r => r.EndsWith(path));
                
                if (matchingResource != null)
                {
                    using var matchStream = assembly.GetManifestResourceStream(matchingResource);
                    if (matchStream != null)
                    {
                        using var reader = new StreamReader(matchStream);
                        return reader.ReadToEnd();
                    }
                }
                
                throw new FileNotFoundException($"Could not find embedded resource: {fullResourceName}\nAvailable resources: {string.Join(", ", availableResources.Take(10))}");
            }
            
            using var streamReader = new StreamReader(stream);
            return streamReader.ReadToEnd();
        });
    }

    private void CopyPageXaml_Click(object sender, RoutedEventArgs e)
    {
        CopyToClipboard(_pageXamlContent, PageXamlCopyStatus);
    }

    private void CopyStyleXaml_Click(object sender, RoutedEventArgs e)
    {
        CopyToClipboard(_styleXamlContent, StyleXamlCopyStatus);
    }

    private void CopyToClipboard(string content, TextBlock statusTextBlock)
    {
        try
        {
            var dataPackage = new DataPackage();
            dataPackage.SetText(content);
            Clipboard.SetContent(dataPackage);
            
            statusTextBlock.Text = "✓ Copied!";
            statusTextBlock.Foreground = new SolidColorBrush(Microsoft.UI.Colors.Green);
            
            // Clear status after 2 seconds
            _ = Task.Delay(2000).ContinueWith(_ =>
            {
                DispatcherQueue.TryEnqueue(() =>
                {
                    statusTextBlock.Text = "";
                });
            });
        }
        catch (Exception ex)
        {
            statusTextBlock.Text = $"Error: {ex.Message}";
            statusTextBlock.Foreground = new SolidColorBrush(Microsoft.UI.Colors.Red);
        }
    }
}
