namespace figma_design_system_uno.Presentation;

public sealed partial class HeroNewsletterVisualizerPage : Page
{
    public HeroNewsletterVisualizerPage()
    {
        this.InitializeComponent();
    }

    private void OnPageSizeChanged(object sender, SizeChangedEventArgs e)
    {
        var width = e.NewSize.Width;
        UpdateResponsiveView(width);
    }

    private void UpdateResponsiveView(double width)
    {
        var isMobile = width < 768;
        HeroNewsletterControlElement.IsMobile = isMobile;
    }
}
