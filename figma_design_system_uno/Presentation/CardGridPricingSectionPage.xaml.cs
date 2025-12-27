using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class CardGridPricingSectionPage : Page
{
    public CardGridPricingSectionModel ViewModel { get; } = new CardGridPricingSectionModel();

    public CardGridPricingSectionPage()
    {
        this.InitializeComponent();
    }
}
