namespace figma_design_system_uno.Presentation;

public sealed partial class SelectFieldPage : Page
{
    public SelectFieldPage()
    {
        this.InitializeComponent();
    }

    private void BackButton_Click(object sender, RoutedEventArgs e)
    {
        Frame.GoBack();
    }
}
