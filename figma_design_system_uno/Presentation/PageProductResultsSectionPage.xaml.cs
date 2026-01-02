using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class PageProductResultsSectionPage : Page
{
    public PageProductResultsSectionModel ViewModel { get; } = new();

    public PageProductResultsSectionPage()
    {
        this.InitializeComponent();
        this.DataContext = ViewModel;
    }
}
