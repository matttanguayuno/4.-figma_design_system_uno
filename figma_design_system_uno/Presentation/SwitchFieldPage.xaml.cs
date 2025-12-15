namespace figma_design_system_uno.Presentation;

public sealed partial class SwitchFieldPage : Page
{
    public SwitchFieldPage()
    {
        this.InitializeComponent();
    }

    private void BackButton_Click(object sender, RoutedEventArgs e)
    {
        Frame.GoBack();
    }
}
