using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class CardGridContentListVisualizerPage : Page
{
    public CardGridContentListVisualizerPage()
    {
        this.InitializeComponent();
        CardGridContentListControl.IsMobile = false;
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
        CardGridContentListControl.IsMobile = width < 768;
    }
}
