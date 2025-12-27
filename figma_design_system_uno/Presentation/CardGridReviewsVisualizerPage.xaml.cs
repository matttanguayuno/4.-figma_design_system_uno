using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class CardGridReviewsVisualizerPage : Page
{
    private const double MobileBreakpoint = 768;

    public CardGridReviewsVisualizerPage()
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
        ReviewsControl.IsMobile = RootGrid.ActualWidth < MobileBreakpoint;
    }
}
