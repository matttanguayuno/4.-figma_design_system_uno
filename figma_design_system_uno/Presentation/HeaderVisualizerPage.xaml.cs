using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class HeaderVisualizerPage : Page
{
    public HeaderVisualizerPage()
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
        bool wasInDifferentMode = HeaderControlElement.IsMobile != isMobile;
        
        HeaderControlElement.IsMobile = isMobile;
        
        // Reset menu state when switching views
        if (wasInDifferentMode)
        {
            HeaderControlElement.IsMenuOpen = false;
        }
    }
}
