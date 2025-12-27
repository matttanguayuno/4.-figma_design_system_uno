namespace figma_design_system_uno.Presentation;

public sealed partial class HeroActionsVisualizerPage : Page
{
    public HeroActionsVisualizerPage()
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
        HeroActionsControlElement.IsMobile = isMobile;
    }
}
