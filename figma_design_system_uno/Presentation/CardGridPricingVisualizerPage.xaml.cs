using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class CardGridPricingVisualizerPage : Page
{
    public CardGridPricingVisualizerPage()
    {
        this.InitializeComponent();
        // Set initial state - default to desktop view
        CardGridPricingControl.IsMobile = false;
    }

    private void OnGridLoaded(object sender, RoutedEventArgs e)
    {
        if (sender is Grid grid)
        {
            var width = grid.ActualWidth;
            if (width > 0)
            {
                CardGridPricingControl.IsMobile = width < 768;
            }
        }
    }

    private void OnPageSizeChanged(object sender, SizeChangedEventArgs e)
    {
        UpdateResponsiveView(e.NewSize.Width);
    }

    private void UpdateResponsiveView(double width)
    {
        if (width > 0)
        {
            CardGridPricingControl.IsMobile = width < 768;
        }
    }
}
