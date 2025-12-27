using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class PanelImageVisualizerPage : Page
{
    public PanelImageVisualizerPage()
    {
        this.InitializeComponent();
    }

    private void OnGridLoaded(object sender, RoutedEventArgs e)
    {
        if (sender is Grid grid)
        {
            UpdateResponsiveView(grid.ActualWidth);
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
            PanelImageControlElement.IsMobile = width < 768;
        }
    }
}
