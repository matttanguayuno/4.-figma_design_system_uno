namespace figma_design_system_uno.Presentation;

public sealed partial class NotificationPage : Page
{
    public NotificationPage()
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
