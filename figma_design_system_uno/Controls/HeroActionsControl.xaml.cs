namespace figma_design_system_uno.Controls;

public sealed partial class HeroActionsControl : UserControl
{
    public static readonly DependencyProperty IsMobileProperty =
        DependencyProperty.Register(
            nameof(IsMobile),
            typeof(bool),
            typeof(HeroActionsControl),
            new PropertyMetadata(false));

    public bool IsMobile
    {
        get => (bool)GetValue(IsMobileProperty);
        set => SetValue(IsMobileProperty, value);
    }

    public HeroActionsControl()
    {
        this.InitializeComponent();
    }
}
