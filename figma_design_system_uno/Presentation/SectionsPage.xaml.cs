using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class SectionsPage : Page
{
    public SectionsPage()
    {
        this.InitializeComponent();
    }

    private void OnBackClick(object sender, RoutedEventArgs e)
    {
        if (Frame.CanGoBack)
        {
            Frame.GoBack();
        }
    }

    private void OnOpenHeaderClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenHeaderClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/HeaderVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just HeaderVisualizerPage (no Shell)
            var headerPage = new HeaderVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = headerPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Header section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenFooterClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenFooterClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/FooterVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just FooterVisualizerPage (no Shell)
            var footerPage = new FooterVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = footerPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Footer section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenHeroBasicClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenHeroBasicClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/HeroBasicVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just HeroBasicVisualizerPage (no Shell)
            var heroPage = new HeroBasicVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = heroPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Hero Basic section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenHeroActionsClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenHeroActionsClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/HeroActionsVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just HeroActionsVisualizerPage (no Shell)
            var heroPage = new HeroActionsVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = heroPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Hero Actions section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenHeroNewsletterClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenHeroNewsletterClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/HeroNewsletterVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just HeroNewsletterVisualizerPage (no Shell)
            var heroPage = new HeroNewsletterVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = heroPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Hero Newsletter section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenHeroFormClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenHeroFormClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/HeroFormVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just HeroFormVisualizerPage (no Shell)
            var heroPage = new HeroFormVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = heroPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Hero Form section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenHeroImageClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenHeroImageClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/HeroImageVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just HeroImageVisualizerPage (no Shell)
            var heroPage = new HeroImageVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = heroPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Hero Image section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenPanelImageContentClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenPanelImageContentClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/PanelImageContentVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just PanelImageContentVisualizerPage (no Shell)
            var panelPage = new PanelImageContentVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = panelPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Panel Image Content section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenPanelImageContentReverseClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenPanelImageContentReverseClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/PanelImageContentReverseVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just PanelImageContentReverseVisualizerPage (no Shell)
            var panelPage = new PanelImageContentReverseVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = panelPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Panel Image Content Reverse section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenPanelImageClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenPanelImageClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/PanelImageVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just PanelImageVisualizerPage (no Shell)
            var panelPage = new PanelImageVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = panelPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Panel Image section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenPanelImageDoubleClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenPanelImageDoubleClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/PanelImageDoubleVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just PanelImageDoubleVisualizerPage (no Shell)
            var panelPage = new PanelImageDoubleVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = panelPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Panel Image Double section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenCardGridPricingClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenCardGridPricingClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/CardGridPricingVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just CardGridPricingVisualizerPage (no Shell)
            var pricingPage = new CardGridPricingVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = pricingPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Card Grid Pricing section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenCardGridIconClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenCardGridIconClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/CardGridIconVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just CardGridIconVisualizerPage (no Shell)
            var iconPage = new CardGridIconVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = iconPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Card Grid Icon section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenCardGridImageClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenCardGridImageClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/CardGridImageVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just CardGridImageVisualizerPage (no Shell)
            var imagePage = new CardGridImageVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = imagePage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Card Grid Image section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenCardGridContentListClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenCardGridContentListClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/CardGridContentListVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just CardGridContentListVisualizerPage (no Shell)
            var contentListPage = new CardGridContentListVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = contentListPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Card Grid Content List section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenCardGridTestimonialsClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenCardGridTestimonialsClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/CardGridTestimonialsVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just CardGridTestimonialsVisualizerPage (no Shell)
            var testimonialsPage = new CardGridTestimonialsVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = testimonialsPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Card Grid Testimonials section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenCardGridReviewsClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenCardGridReviewsClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/CardGridReviewsVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just CardGridReviewsVisualizerPage (no Shell)
            var reviewsPage = new CardGridReviewsVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = reviewsPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Card Grid Reviews section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenPageAccordionClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenPageAccordionClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/PageAccordionVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just PageAccordionVisualizerPage (no Shell)
            var accordionPage = new PageAccordionVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = accordionPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Page Accordion section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenPageProductClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenPageProductClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/PageProductVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just PageProductVisualizerPage (no Shell)
            var productPage = new PageProductVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = productPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Page Product section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenPageProductResultsClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenPageProductResultsClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/PageProductResultsVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just PageProductResultsVisualizerPage (no Shell)
            var productResultsPage = new PageProductResultsVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = productResultsPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Page Product Results section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }

    private void OnOpenPageNewsletterClick(object sender, RoutedEventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("OnOpenPageNewsletterClick called");
            
#if __WASM__
            // For WASM, open in new browser tab using JavaScript
            var script = "window.open('/PageNewsletterVisualizer', '_blank');";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(script);
            System.Diagnostics.Debug.WriteLine("Opened new tab with JavaScript");
#else
            // For desktop, create new window with just PageNewsletterVisualizerPage (no Shell)
            var newsletterPage = new PageNewsletterVisualizerPage();
            var newWindow = new Microsoft.UI.Xaml.Window();
            newWindow.Content = newsletterPage;
            
            // Maximize the new window
            var appWindow = newWindow.AppWindow;
            if (appWindow is not null)
            {
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                if (presenter is not null)
                {
                    presenter.Maximize();
                }
            }
            
            newWindow.Activate();
            System.Diagnostics.Debug.WriteLine("Window created and activated");
#endif
        }
        catch (System.Exception ex)
        {
            // Log error for debugging
            System.Diagnostics.Debug.WriteLine($"Error opening Page Newsletter section: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }
}
