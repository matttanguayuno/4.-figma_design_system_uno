using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class TooltipPage : Page
{
    public TooltipPage()
    {
        this.InitializeComponent();
        this.Loaded += TooltipPage_Loaded;
    }

    private void TooltipPage_Loaded(object sender, RoutedEventArgs e)
    {
        // Open all TeachingTips after page is loaded
        TopTeachingTip.IsOpen = true;
        BottomTeachingTip.IsOpen = true;
        LeftTeachingTip.IsOpen = true;
        RightTeachingTip.IsOpen = true;
    }

    private void OnBackClick(object sender, RoutedEventArgs e)
    {
        if (Frame.CanGoBack)
        {
            Frame.GoBack();
        }
    }
}
