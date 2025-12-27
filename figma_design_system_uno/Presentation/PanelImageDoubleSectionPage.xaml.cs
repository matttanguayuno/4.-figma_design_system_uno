using figma_design_system_uno.Presentation.Models;
using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation;

public sealed partial class PanelImageDoubleSectionPage : Page
{
    public PanelImageDoubleSectionModel ViewModel { get; } = new();

    public PanelImageDoubleSectionPage()
    {
        this.InitializeComponent();
    }
}
