namespace figma_design_system_uno.Presentation;

public sealed partial class DialogPage : Page
{
    public DialogPage()
    {
        this.InitializeComponent();
    }

    private void OnBackClick(object sender, RoutedEventArgs e)
    {
        if (Frame.CanGoBack)
        {
            Frame.GoBack();
        }
    }
}
