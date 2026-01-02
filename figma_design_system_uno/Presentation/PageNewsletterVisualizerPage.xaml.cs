using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class PageNewsletterVisualizerPage : Page
{
    public PageNewsletterVisualizerPage()
    {
        this.InitializeComponent();
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        UpdateLayoutForSize();
    }

    private void OnSizeChanged(object sender, SizeChangedEventArgs e)
    {
        UpdateLayoutForSize();
    }

    private void UpdateLayoutForSize()
    {
        // Newsletter section doesn't have a mobile-specific layout in the control
        // but we can add responsive behavior if needed in the future
    }
}
