using CommunityToolkit.Mvvm.ComponentModel;

namespace figma_design_system_uno.Presentation;

public partial class CardGridImageSectionModel : ObservableObject
{
    [ObservableProperty]
    private string _deviceMode = "Desktop";

    [ObservableProperty]
    private double _deviceWidth = 1200;

    [ObservableProperty]
    private bool _isMobile = false;

    partial void OnDeviceModeChanged(string value)
    {
        IsMobile = value == "Mobile";
        DeviceWidth = IsMobile ? 375 : 1200;
    }
}
