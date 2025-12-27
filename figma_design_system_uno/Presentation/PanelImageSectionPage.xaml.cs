using figma_design_system_uno.Presentation.Models;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class PanelImageSectionPage : Page
{
    public PanelImageSectionModel ViewModel { get; } = new();

    public PanelImageSectionPage()
    {
        this.InitializeComponent();
    }
}
