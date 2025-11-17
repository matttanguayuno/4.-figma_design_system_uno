namespace figma_design_system_uno.Presentation;

public partial record MainModel
{
    private INavigator _navigator;

    public MainModel(
        IStringLocalizer localizer,
        IOptions<AppConfig> appInfo,
        INavigator navigator)
    {
        _navigator = navigator;
        Title = "Main";
        Title += $" - {localizer["ApplicationName"]}";
        Title += $" - {appInfo?.Value?.Environment}";
    }

    public string? Title { get; }

    public IState<string> Name => State<string>.Value(this, () => string.Empty);

    public async Task GoToSecond()
    {
        var name = await Name;
        await _navigator.NavigateViewModelAsync<SecondModel>(this, data: new Entity(name!));
    }

    public async Task GoToFigmaComponentList()
    {
        await _navigator.NavigateViewModelAsync<FigmaComponentListModel>(this);
    }

    public async Task GoToTag()
    {
        await _navigator.NavigateViewModelAsync<TagModel>(this);
    }

    public async Task GoToTagToggle()
    {
        await _navigator.NavigateViewModelAsync<TagToggleModel>(this);
    }

}
