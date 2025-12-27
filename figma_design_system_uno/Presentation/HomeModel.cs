using CommunityToolkit.Mvvm.Input;

namespace figma_design_system_uno.Presentation;

public record ComponentCard(string Icon, string Title, string Description, AsyncRelayCommand NavigateCommand);

public partial record HomeModel
{
    private readonly Frame _frame;
    
    public ComponentCard[] ComponentCards { get; init; }
    public ComponentCard[] PageCards { get; init; }

    public HomeModel(Frame frame)
    {
        _frame = frame;

        ComponentCards = new[]
        {
            new ComponentCard("\uE700", "Accordion", "Expandable content panels with chevron icons, supporting multiple items with collapsed and expanded states.", new AsyncRelayCommand(GoToAccordion)),
            new ComponentCard("\uE77B", "Avatar", "User profile images with multiple size variants (16px, 20px, 24px, 28px, 32px, 36px) and placeholder state.", new AsyncRelayCommand(GoToAvatar)),
            new ComponentCard("\uE8A1", "Buttons", "Primary, neutral, subtle button variants with medium (40px) and small (32px) sizes. Includes danger buttons and icon-only buttons.", new AsyncRelayCommand(GoToButtons)),
            new ComponentCard("\uE8D4", "Cards", "Basic card components with title, description, actions, and visual content support.", new AsyncRelayCommand(GoToCards)),
            new ComponentCard("\uE8A7", "Dialog", "Modal dialog components with card and sheet variants, including heading, body text, action buttons, and dismissible close icon.", new AsyncRelayCommand(GoToDialog)),
            new ComponentCard("\uE70F", "Input", "Input field components including text inputs, checkboxes, radio buttons, select fields, search, sliders, textareas, and switches.", new AsyncRelayCommand(GoToInputFields)),
            new ComponentCard("\uE734", "Menu", "Menu components with headers, items, separators, headings, and keyboard shortcuts for contextual navigation.", new AsyncRelayCommand(GoToMenu)),
            new ComponentCard("\uE700", "Navigation", "Navigation button and pill components with column/row layouts, default, hover, and active states for app navigation.", new AsyncRelayCommand(GoToNavigation)),
            new ComponentCard("\uE7E7", "Notification", "Message and alert notification components with icons, titles, body text, action buttons, and dismissible close functionality.", new AsyncRelayCommand(GoToNotification)),
            new ComponentCard("\uE8B1", "Pagination", "Pagination components with page numbers, previous/next buttons, and current page indicators for navigating through content.", new AsyncRelayCommand(GoToPagination)),
            new ComponentCard("\uE8A6", "Tabs", "Tab navigation components with default, hover, active, and inactive states for organizing content into sections.", new AsyncRelayCommand(GoToTabs)),
            new ComponentCard("\uE8EC", "Tag", "Label tags for categorization with close/dismiss functionality.", new AsyncRelayCommand(GoToTag)),
            new ComponentCard("\uE946", "Tooltip", "Contextual information popups with arrow indicators positioned at top, bottom, left, or right relative to target elements.", new AsyncRelayCommand(GoToTooltip)),
        };

        PageCards = new[]
        {
            new ComponentCard("\uE8A2", "Forms", "Form layouts including shipping, contact, newsletter, login, register, and forgot password forms with proper field validation patterns.", new AsyncRelayCommand(GoToForms)),
            new ComponentCard("\uE8BC", "Sections", "Full-width responsive sections like headers, footers, and hero sections that adapt to desktop and mobile viewports.", new AsyncRelayCommand(GoToSections)),
        };
    }

    public async Task GoToAccordion() { _frame.Navigate(typeof(AccordionPage)); await Task.CompletedTask; }
    public async Task GoToAvatar() { _frame.Navigate(typeof(AvatarPage)); await Task.CompletedTask; }
    public async Task GoToButtons() { _frame.Navigate(typeof(ButtonsPage)); await Task.CompletedTask; }
    public async Task GoToCards() { _frame.Navigate(typeof(CardsPage)); await Task.CompletedTask; }
    public async Task GoToDialog() { _frame.Navigate(typeof(DialogPage)); await Task.CompletedTask; }
    public async Task GoToForms() { _frame.Navigate(typeof(FormsPage)); await Task.CompletedTask; }
    public async Task GoToInputFields() { _frame.Navigate(typeof(InputFieldsPage)); await Task.CompletedTask; }
    public async Task GoToMenu() { _frame.Navigate(typeof(MenuPage)); await Task.CompletedTask; }
    public async Task GoToNavigation() { _frame.Navigate(typeof(NavigationPage)); await Task.CompletedTask; }
    public async Task GoToNotification() { _frame.Navigate(typeof(NotificationPage)); await Task.CompletedTask; }
    public async Task GoToPagination() { _frame.Navigate(typeof(PaginationPage)); await Task.CompletedTask; }
    public async Task GoToTabs() { _frame.Navigate(typeof(TabsPage)); await Task.CompletedTask; }
    public async Task GoToTag() { _frame.Navigate(typeof(TagPage)); await Task.CompletedTask; }
    public async Task GoToTooltip() { _frame.Navigate(typeof(TooltipPage)); await Task.CompletedTask; }
    public async Task GoToSections() { _frame.Navigate(typeof(SectionsPage)); await Task.CompletedTask; }
}
