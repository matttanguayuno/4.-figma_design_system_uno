using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class PageProductVisualizerPage : Page
{
    private const double MobileBreakpoint = 768;

    public PageProductVisualizerPage()
    {
        this.InitializeComponent();
    }

    private void RootGrid_Loaded(object sender, RoutedEventArgs e)
    {
        UpdateLayoutForSize();
    }

    private void RootGrid_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        UpdateLayoutForSize();
    }

    private void UpdateLayoutForSize()
    {
        var width = RootGrid.ActualWidth;
        ProductControl.IsMobile = width < MobileBreakpoint;
    }
}
