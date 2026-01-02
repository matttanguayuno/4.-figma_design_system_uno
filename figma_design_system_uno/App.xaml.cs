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

        // Maximize window BEFORE any content is loaded
#if !__WASM__ && !__IOS__ && !__ANDROID__
        var appWindow = MainWindow.AppWindow;
        if (appWindow is not null)
        {
            var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
            if (presenter is not null)
            {
                presenter.Maximize();
            }
        }
#endif

        // Check if this is a visualizer page request (no Shell needed)
#if __WASM__
        var currentUrl = Uno.Foundation.WebAssemblyRuntime.InvokeJS("window.location.pathname");
        if (currentUrl.Contains("HeaderVisualizer"))
        {
            MainWindow.Content = new Presentation.HeaderVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("FooterVisualizer"))
        {
            MainWindow.Content = new Presentation.FooterVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("HeroBasicVisualizer"))
        {
            MainWindow.Content = new Presentation.HeroBasicVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("HeroActionsVisualizer"))
        {
            MainWindow.Content = new Presentation.HeroActionsVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("HeroNewsletterVisualizer"))
        {
            MainWindow.Content = new Presentation.HeroNewsletterVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("HeroFormVisualizer"))
        {
            MainWindow.Content = new Presentation.HeroFormVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("HeroImageVisualizer"))
        {
            MainWindow.Content = new Presentation.HeroImageVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("PanelImageContentVisualizer"))
        {
            MainWindow.Content = new Presentation.PanelImageContentVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("PanelImageContentReverseVisualizer"))
        {
            MainWindow.Content = new Presentation.PanelImageContentReverseVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("PanelImageVisualizer"))
        {
            MainWindow.Content = new Presentation.PanelImageVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("PanelImageDoubleVisualizer"))
        {
            MainWindow.Content = new Presentation.PanelImageDoubleVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("CardGridPricingVisualizer"))
        {
            MainWindow.Content = new Presentation.CardGridPricingVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("CardGridIconVisualizer"))
        {
            MainWindow.Content = new Presentation.CardGridIconVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("CardGridImageVisualizer"))
        {
            MainWindow.Content = new Presentation.CardGridImageVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("CardGridContentListVisualizer"))
        {
            MainWindow.Content = new Presentation.CardGridContentListVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("CardGridTestimonialsVisualizer"))
        {
            MainWindow.Content = new Presentation.CardGridTestimonialsVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("CardGridReviewsVisualizer"))
        {
            MainWindow.Content = new Presentation.CardGridReviewsVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("PageAccordionVisualizer"))
        {
            MainWindow.Content = new Presentation.PageAccordionVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("PageProductVisualizer"))
        {
            MainWindow.Content = new Presentation.PageProductVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("PageProductResultsVisualizer"))
        {
            MainWindow.Content = new Presentation.PageProductResultsVisualizerPage();
            MainWindow.Activate();
            return;
        }
        else if (currentUrl.Contains("PageNewsletterVisualizer"))
        {
            MainWindow.Content = new Presentation.PageNewsletterVisualizerPage();
            MainWindow.Activate();
            return;
        }
#endif

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
            new ViewMap<TooltipPage, TooltipModel>()
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
                    new ("Tooltip", View: views.FindByViewModel<TooltipModel>())
                ]
            )
        );
    }
}
