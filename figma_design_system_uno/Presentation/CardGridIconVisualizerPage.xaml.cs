using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class CardGridIconVisualizerPage : Page
{
    public CardGridIconVisualizerPage()
    {
        this.InitializeComponent();
        CardGridIconControl.IsMobile = false;
    }

    private void OnGridLoaded(object sender, RoutedEventArgs e)
    {
        if (sender is Grid grid && grid.ActualWidth > 0)
        {
            CardGridIconControl.IsMobile = grid.ActualWidth < 768;
        }
    }

    private void OnPageSizeChanged(object sender, SizeChangedEventArgs e)
    {
        UpdateResponsiveView(e.NewSize.Width);
    }

    private void UpdateResponsiveView(double width)
    {
        CardGridIconControl.IsMobile = width < 768;
    }
}
