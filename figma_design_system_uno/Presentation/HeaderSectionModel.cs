using CommunityToolkit.Mvvm.ComponentModel;

namespace figma_design_system_uno.Presentation;

public partial class HeaderSectionModel : ObservableObject
{
    [ObservableProperty]
    private string _deviceMode = "Desktop";

    [ObservableProperty]
    private double _deviceWidth = 1200;

    [ObservableProperty]
    private bool _isMobileMenuOpen = false;

    public bool IsMobile => DeviceMode == "Mobile";

    partial void OnDeviceModeChanged(string value)
    {
        DeviceWidth = value == "Desktop" ? 1200 : 375;
        IsMobileMenuOpen = false; // Reset menu state when switching devices
        OnPropertyChanged(nameof(IsMobile));
    }
}
