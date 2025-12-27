using CommunityToolkit.Mvvm.ComponentModel;

namespace figma_design_system_uno.Presentation;

public partial class HeroBasicSectionModel : ObservableObject
{
    [ObservableProperty]
    private string _deviceMode = "Desktop";

    [ObservableProperty]
    private double _deviceWidth = 1200;

    public bool IsMobile => DeviceMode == "Mobile";

    partial void OnDeviceModeChanged(string value)
    {
        DeviceWidth = value == "Desktop" ? 1200 : 375;
        OnPropertyChanged(nameof(IsMobile));
    }
}
