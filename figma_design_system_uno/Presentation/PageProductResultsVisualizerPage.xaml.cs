using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class PageProductResultsVisualizerPage : Page
{
    public PageProductResultsVisualizerPage()
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
        if (RootGrid.ActualWidth < 768)
        {
            ProductResultsControl.IsMobile = true;
        }
        else
        {
            ProductResultsControl.IsMobile = false;
        }
    }
}
