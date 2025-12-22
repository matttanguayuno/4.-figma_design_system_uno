namespace figma_design_system_uno.Presentation;

public sealed partial class PaginationPage : Page
{
    public PaginationPage()
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
