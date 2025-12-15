namespace figma_design_system_uno.Presentation;

public sealed partial class CheckboxFieldsPage : Page
{
    public CheckboxFieldsPage()
    {
        this.InitializeComponent();
    }

    private void BackButton_Click(object sender, RoutedEventArgs e)
    {
        Frame.GoBack();
    }
}
