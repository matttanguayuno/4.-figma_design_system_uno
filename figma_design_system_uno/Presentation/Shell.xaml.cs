using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using Windows.UI.Core;

namespace figma_design_system_uno.Presentation;

public sealed partial class Shell : UserControl, IContentControlProvider
{
    private readonly Dictionary<string, Type> _pages = new()
    {
        { "Home", typeof(HomePage) },
        { "Accordion", typeof(AccordionPage) },
        { "Avatar", typeof(AvatarPage) },
        { "Buttons", typeof(ButtonsPage) },
        { "Cards", typeof(CardsPage) },
        { "Dialog", typeof(DialogPage) },
        { "Forms", typeof(FormsPage) },
        { "InputFields", typeof(InputFieldsPage) },
        { "Menu", typeof(MenuPage) },
        { "Navigation", typeof(NavigationPage) },
        { "Notification", typeof(NotificationPage) },
        { "Pagination", typeof(PaginationPage) },
        { "Tabs", typeof(TabsPage) },
        { "Tag", typeof(TagPage) },
        { "Tooltip", typeof(TooltipPage) },
        { "Sections", typeof(SectionsPage) },
        { "HeaderSection", typeof(HeaderSectionPage) },
        { "HeaderVisualizer", typeof(HeaderVisualizerPage) },
        { "FooterSection", typeof(FooterSectionPage) },
        { "FooterVisualizer", typeof(FooterVisualizerPage) },
        { "HeroBasicSection", typeof(HeroBasicSectionPage) },
        { "HeroBasicVisualizer", typeof(HeroBasicVisualizerPage) },
        { "HeroActionsSection", typeof(HeroActionsSectionPage) },
        { "HeroActionsVisualizer", typeof(HeroActionsVisualizerPage) },
        { "HeroNewsletterSection", typeof(HeroNewsletterSectionPage) },
        { "HeroNewsletterVisualizer", typeof(HeroNewsletterVisualizerPage) },
        { "HeroFormSection", typeof(HeroFormSectionPage) },
        { "HeroFormVisualizer", typeof(HeroFormVisualizerPage) },
        { "HeroImageSection", typeof(HeroImageSectionPage) },
        { "HeroImageVisualizer", typeof(HeroImageVisualizerPage) },
        { "PanelImageContentSection", typeof(PanelImageContentSectionPage) },
        { "PanelImageContentVisualizer", typeof(PanelImageContentVisualizerPage) },
        { "PanelImageContentReverseSection", typeof(PanelImageContentReverseSectionPage) },
        { "PanelImageContentReverseVisualizer", typeof(PanelImageContentReverseVisualizerPage) },
        { "PanelImageSection", typeof(PanelImageSectionPage) },
        { "PanelImageVisualizer", typeof(PanelImageVisualizerPage) },
        { "PanelImageDoubleSection", typeof(PanelImageDoubleSectionPage) },
        { "PanelImageDoubleVisualizer", typeof(PanelImageDoubleVisualizerPage) },
        { "CardGridPricingSection", typeof(CardGridPricingSectionPage) },
        { "CardGridPricingVisualizer", typeof(CardGridPricingVisualizerPage) },
        { "CardGridIconSection", typeof(CardGridIconSectionPage) },
        { "CardGridIconVisualizer", typeof(CardGridIconVisualizerPage) },
        { "CardGridImageSection", typeof(CardGridImageSectionPage) },
        { "CardGridImageVisualizer", typeof(CardGridImageVisualizerPage) },
        { "CardGridContentListSection", typeof(CardGridContentListSectionPage) },
        { "CardGridContentListVisualizer", typeof(CardGridContentListVisualizerPage) },
        { "CardGridTestimonialsSection", typeof(CardGridTestimonialsSectionPage) },
        { "CardGridTestimonialsVisualizer", typeof(CardGridTestimonialsVisualizerPage) },
        { "CardGridReviewsSection", typeof(CardGridReviewsSectionPage) },
        { "CardGridReviewsVisualizer", typeof(CardGridReviewsVisualizerPage) },
        { "PageAccordionSection", typeof(PageAccordionSectionPage) },
        { "PageAccordionVisualizer", typeof(PageAccordionVisualizerPage) },
        { "PageProductSection", typeof(PageProductSectionPage) },
        { "PageProductVisualizer", typeof(PageProductVisualizerPage) },
        { "PageProductResultsSection", typeof(PageProductResultsSectionPage) },
        { "PageProductResultsVisualizer", typeof(PageProductResultsVisualizerPage) }
    };

    private string _currentPage = "Home";
    private bool _isNavigatingProgrammatically = false;

    public Shell()
    {
        this.InitializeComponent();
        this.Loaded += Shell_Loaded;
        
        // Enable browser back button integration will be set up in Shell_Loaded
        
        // Enable browser navigation integration
        SystemNavigationManager.GetForCurrentView().BackRequested += Shell_BackRequested;
    }
    
    private void Shell_BackRequested(object? sender, BackRequestedEventArgs e)
    {
        if (ContentFrame.CanGoBack)
        {
            e.Handled = true;
            ContentFrame.GoBack();
        }
    }

    private void ContentFrame_Navigated(object sender, Microsoft.UI.Xaml.Navigation.NavigationEventArgs e)
    {
        // Update button states when navigation occurs
        var pageType = e.SourcePageType;
        var pageTag = _pages.FirstOrDefault(p => p.Value == pageType).Key;
        if (!string.IsNullOrEmpty(pageTag))
        {
            UpdateButtonStates(pageTag);
        }
        
        // Update browser history for WASM (only if not already navigating via browser back)
        #if __WASM__
        if (!_isNavigatingProgrammatically && !string.IsNullOrEmpty(pageTag))
        {
            var url = pageTag == "Home" ? "/" : $"#{pageTag}";
            Uno.Foundation.WebAssemblyRuntime.InvokeJS(
                $"if (window.location.hash !== '#{pageTag}') {{ history.pushState({{page: '{pageTag}'}}, '', '{url}'); }}"
            );
        }
        _isNavigatingProgrammatically = false;
        #endif
    }

    private void Shell_Loaded(object sender, RoutedEventArgs e)
    {
        // Set up navigation events
        ContentFrame.Navigated += ContentFrame_Navigated;
        
        // Navigate to Home page by default
        ContentFrame.Navigate(typeof(HomePage));
        
        // Set the Frame reference on HomePage
        if (ContentFrame.Content is HomePage homePage)
        {
            homePage.SetNavigationFrame(ContentFrame);
        }
        
        UpdateButtonStates("Home");
    }

    public ContentControl ContentControl => ContentFrame;

    private void Navigate_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button button && button.Tag is string tag && _pages.TryGetValue(tag, out var pageType))
        {
            ContentFrame.Navigate(pageType);
            
            // If navigating to HomePage, set its DataContext with the Frame
            if (pageType == typeof(HomePage) && ContentFrame.Content is HomePage homePage)
            {
                homePage.SetNavigationFrame(ContentFrame);
            }
            
            UpdateButtonStates(tag);
        }
    }

    private void UpdateButtonStates(string currentPageTag)
    {
        _currentPage = currentPageTag;
        
        var selectedStyle = (Style)Application.Current.Resources["OutlinedButtonStyle"];
        var unselectedStyle = (Style)Application.Current.Resources["TextButtonStyle"];
        
        // Find all navigation buttons and update their visual state
        var buttons = FindNavigationButtons(this);
        foreach (var button in buttons)
        {
            if (button.Tag is string tag)
            {
                button.Style = tag == _currentPage ? selectedStyle : unselectedStyle;
            }
        }
    }

    private IEnumerable<Button> FindNavigationButtons(DependencyObject parent)
    {
        var count = VisualTreeHelper.GetChildrenCount(parent);
        for (int i = 0; i < count; i++)
        {
            var child = VisualTreeHelper.GetChild(parent, i);
            if (child is Button button && button.Tag is string)
            {
                yield return button;
            }
            
            foreach (var descendant in FindNavigationButtons(child))
            {
                yield return descendant;
            }
        }
    }
}
