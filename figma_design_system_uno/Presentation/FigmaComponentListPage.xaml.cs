namespace figma_design_system_uno.Presentation;

public sealed partial class FigmaComponentListPage : Page
{
    private FigmaComponentListModel? ViewModel => DataContext as FigmaComponentListModel;

    public FigmaComponentListPage()
    {
        this.InitializeComponent();
    }

    private async void OnFetchClick(object sender, RoutedEventArgs e)
    {
        if (ViewModel == null) return;

        var fileKey = FileKeyInput.Text;
        var token = AccessTokenInput.Password;

        await ViewModel.FileKey.UpdateAsync(_ => fileKey, CancellationToken.None);
        await ViewModel.AccessToken.UpdateAsync(_ => token, CancellationToken.None);
        await ViewModel.FetchComponents();
    }
}
