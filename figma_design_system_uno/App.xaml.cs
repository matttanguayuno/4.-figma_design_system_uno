using Uno.Resizetizer;
using Uno.Extensions.Navigation.Regions;

namespace figma_design_system_uno;

public partial class App : Application
{
    /// <summary>
    /// Initializes the singleton application object. This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App()
    {
        this.InitializeComponent();
    }

    protected Window? MainWindow { get; private set; }
    protected IHost? Host { get; private set; }

    protected async override void OnLaunched(LaunchActivatedEventArgs args)
    {
        var builder = this.CreateBuilder(args)
            // Add navigation support for toolkit controls such as TabBar and NavigationView
            .UseToolkitNavigation()
            .Configure(host => host
#if DEBUG
                // Switch to Development environment when running in DEBUG
                .UseEnvironment(Environments.Development)
#endif
                .UseLogging(configure: (context, logBuilder) =>
                {
                    // Configure log levels for different categories of logging
                    logBuilder
                        .SetMinimumLevel(
                            context.HostingEnvironment.IsDevelopment() ?
                                LogLevel.Information :
                                LogLevel.Warning)

                        // Default filters for core Uno Platform namespaces
                        .CoreLogLevel(LogLevel.Warning);

                    // Uno Platform namespace filter groups
                    // Uncomment individual methods to see more detailed logging
                    //// Generic Xaml events
                    //logBuilder.XamlLogLevel(LogLevel.Debug);
                    //// Layout specific messages
                    //logBuilder.XamlLayoutLogLevel(LogLevel.Debug);
                    //// Storage messages
                    //logBuilder.StorageLogLevel(LogLevel.Debug);
                    //// Binding related messages
                    //logBuilder.XamlBindingLogLevel(LogLevel.Debug);
                    //// Binder memory references tracking
                    //logBuilder.BinderMemoryReferenceLogLevel(LogLevel.Debug);
                    //// DevServer and HotReload related
                    //logBuilder.HotReloadCoreLogLevel(LogLevel.Information);
                    //// Debug JS interop
                    //logBuilder.WebAssemblyLogLevel(LogLevel.Debug);

                }, enableUnoLogging: true)
                .UseConfiguration(configure: configBuilder =>
                    configBuilder
                        .EmbeddedSource<App>()
                        .Section<AppConfig>()
                )
                // Enable localization (see appsettings.json for supported languages)
                .UseLocalization()
                .UseHttp((context, services) => {
#if DEBUG
                // DelegatingHandler will be automatically injected
                services.AddTransient<DelegatingHandler, DebugHttpHandler>();
#endif

})
                .ConfigureServices((context, services) =>
                {
                    // TODO: Register your services
                    //services.AddSingleton<IMyService, MyService>();
                })
                .UseNavigation(ReactiveViewModelMappings.ViewModelMappings, RegisterRoutes)
            );
        MainWindow = builder.Window;

        #if DEBUG
        MainWindow.UseStudio();
#endif
                MainWindow.SetWindowIcon();

        // Set window to maximized (full screen) on desktop
        var appWindow = MainWindow.AppWindow;
        if (appWindow is not null)
        {
            var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
            if (presenter is not null)
            {
                presenter.Maximize();
            }
        }

        Host = await builder.NavigateAsync<Shell>();
    }

    private static void RegisterRoutes(IViewRegistry views, IRouteRegistry routes)
    {

        views.Register(
            new ViewMap(ViewModel: typeof(ShellModel)),
            new ViewMap<HomePage, HomeModel>(),
            new ViewMap<AccordionPage, AccordionModel>(),
            new ViewMap<AvatarPage, AvatarModel>(),
            new ViewMap<ButtonsPage, ButtonsModel>(),
            new ViewMap<CardsPage, CardsModel>(),
            new ViewMap<DialogPage, DialogModel>(),
            new ViewMap<InputFieldsPage, InputFieldsModel>(),
            new ViewMap<MenuPage, MenuModel>(),
            new ViewMap<TagPage, TagModel>(),
            new ViewMap<TagTogglePage, TagToggleModel>()
        );

        routes.Register(
            new RouteMap("", View: views.FindByViewModel<ShellModel>(),
                Nested:
                [
                    new ("Home", View: views.FindByViewModel<HomeModel>(), IsDefault:true),
                    new ("Accordion", View: views.FindByViewModel<AccordionModel>()),
                    new ("Avatar", View: views.FindByViewModel<AvatarModel>()),
                    new ("Buttons", View: views.FindByViewModel<ButtonsModel>()),
                    new ("Cards", View: views.FindByViewModel<CardsModel>()),
                    new ("Dialog", View: views.FindByViewModel<DialogModel>()),
                    new ("InputFields", View: views.FindByViewModel<InputFieldsModel>()),
                    new ("Menu", View: views.FindByViewModel<MenuModel>()),
                    new ("Tag", View: views.FindByViewModel<TagModel>()),
                    new ("TagToggle", View: views.FindByViewModel<TagToggleModel>())
                ]
            )
        );
    }
}
