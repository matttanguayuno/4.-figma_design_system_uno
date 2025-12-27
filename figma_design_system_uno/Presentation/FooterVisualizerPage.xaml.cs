using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class FooterVisualizerPage : Page
{
    public FooterVisualizerPage()
    {
        this.InitializeComponent();
    }

    private void OnPageSizeChanged(object sender, SizeChangedEventArgs e)
    {
        UpdateResponsiveView(e.NewSize.Width);
    }

    private void UpdateResponsiveView(double width)
    {
        // Switch to mobile view if width is less than 768px
        bool isMobile = width < 768;
        
        FooterControlElement.IsMobile = isMobile;
    }
}
