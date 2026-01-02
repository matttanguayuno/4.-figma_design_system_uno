using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class PageNewsletterSectionPage : Page
{
    public PageNewsletterSectionModel ViewModel { get; } = new();

    public PageNewsletterSectionPage()
    {
        this.InitializeComponent();
        this.DataContext = ViewModel;
    }
}
