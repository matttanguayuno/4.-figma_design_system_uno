namespace figma_design_system_uno.Presentation;

public sealed partial class InputFieldsPage : Page
{
    public InputFieldsPage()
    {
        this.InitializeComponent();
    }

    private void BackButton_Click(object sender, RoutedEventArgs e)
    {
        Frame.GoBack();
    }
}
