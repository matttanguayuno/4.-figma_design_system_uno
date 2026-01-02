using CommunityToolkit.Mvvm.ComponentModel;

namespace figma_design_system_uno.Presentation;

public partial class PageProductSectionModel : ObservableObject
{
    [ObservableProperty]
    private int deviceMode = 0; // 0 = Desktop, 1 = Mobile

    public bool IsMobile => DeviceMode == 1;

    public double DeviceWidth => DeviceMode == 0 ? 1200 : 375;

    partial void OnDeviceModeChanged(int value)
    {
        OnPropertyChanged(nameof(IsMobile));
        OnPropertyChanged(nameof(DeviceWidth));
    }
}
