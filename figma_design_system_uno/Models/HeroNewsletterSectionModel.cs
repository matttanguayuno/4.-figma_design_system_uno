using CommunityToolkit.Mvvm.ComponentModel;

namespace figma_design_system_uno.Models;

public partial class HeroNewsletterSectionModel : ObservableObject
{
    [ObservableProperty]
    private string _deviceMode = "Desktop";

    public double DeviceWidth => DeviceMode == "Desktop" ? 1200 : 375;
    public bool IsMobile => DeviceMode == "Mobile";

    partial void OnDeviceModeChanged(string value)
    {
        OnPropertyChanged(nameof(DeviceWidth));
        OnPropertyChanged(nameof(IsMobile));
    }
}
