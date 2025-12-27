using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class PanelImageContentVisualizerPage : Page
{
    public PanelImageContentVisualizerPage()
    {
        InitializeComponent();
    }

    private void OnPageSizeChanged(object sender, SizeChangedEventArgs e)
    {
        var width = e.NewSize.Width;
        UpdateResponsiveView(width);
    }

    private void UpdateResponsiveView(double width)
    {
        var isMobile = width < 768;
        PanelImageContentControlElement.IsMobile = isMobile;
    }
}
