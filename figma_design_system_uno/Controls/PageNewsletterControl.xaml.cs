using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Controls;

public sealed partial class PageNewsletterControl : UserControl
{
    public PageNewsletterControl()
    {
        this.InitializeComponent();
    }

    private void OnSizeChanged(object sender, SizeChangedEventArgs e)
    {
        UpdateLayoutForSize(e.NewSize.Width);
    }

    private void UpdateLayoutForSize(double width)
    {
        if (width < 768)
        {
            // Mobile layout
            RootLayout.Padding = new Thickness(24);
            FormLayout.Width = double.NaN; // Auto width
        }
        else
        {
            // Desktop layout
            RootLayout.Padding = new Thickness(64);
            FormLayout.Width = 338;
        }
    }
}
