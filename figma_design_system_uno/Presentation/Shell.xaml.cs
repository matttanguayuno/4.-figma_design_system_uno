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
        { "InputFields", typeof(InputFieldsPage) },
        { "RadioFields", typeof(RadioFieldPage) },
        { "Search", typeof(SearchPage) },
        { "SelectField", typeof(SelectFieldPage) },
        { "SwitchFields", typeof(SwitchFieldPage) },
        { "Tag", typeof(TagPage) },
        { "TagToggle", typeof(TagTogglePage) },
        { "TextareaField", typeof(TextareaFieldPage) }
    };

    private string _currentPage = "Home";

    public Shell()
    {
        this.InitializeComponent();
        this.Loaded += Shell_Loaded;
    }

    private void Shell_Loaded(object sender, RoutedEventArgs e)
    {
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
        
        // Find all navigation buttons and update their visual state
        var buttons = FindNavigationButtons(this);
        foreach (var button in buttons)
        {
            if (button.Tag is string tag)
            {
                button.FontWeight = tag == _currentPage ? Microsoft.UI.Text.FontWeights.SemiBold : Microsoft.UI.Text.FontWeights.Normal;
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
