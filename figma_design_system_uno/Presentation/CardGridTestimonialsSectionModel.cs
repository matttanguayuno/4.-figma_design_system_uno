using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace figma_design_system_uno.Presentation;

public partial class CardGridTestimonialsSectionPage : Microsoft.UI.Xaml.Controls.Page
{
    public CardGridTestimonialsSectionPage()
    {
        this.InitializeComponent();
    }
}

public partial class CardGridTestimonialsSectionModel : ObservableObject
{
    private INavigator _navigator;

    [ObservableProperty]
    private int _deviceMode;

    [ObservableProperty]
    private double _deviceWidth = 1200;

    [ObservableProperty]
    private bool _isMobile;

    public CardGridTestimonialsSectionModel(INavigator navigator)
    {
        _navigator = navigator;
    }

    partial void OnDeviceModeChanged(int value)
    {
        IsMobile = value == 1;
        DeviceWidth = IsMobile ? 375 : 1200;
    }

    [RelayCommand]
    private async Task GoBack()
    {
        await _navigator.NavigateBackAsync(this);
    }
}
