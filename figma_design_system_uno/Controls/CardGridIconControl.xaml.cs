using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;

namespace figma_design_system_uno.Controls;

public sealed partial class CardGridIconControl : UserControl
{
    public static readonly DependencyProperty IsMobileProperty =
        DependencyProperty.Register(
            nameof(IsMobile),
            typeof(bool),
            typeof(CardGridIconControl),
            new PropertyMetadata(false));

    public bool IsMobile
    {
        get => (bool)GetValue(IsMobileProperty);
        set => SetValue(IsMobileProperty, value);
    }

    public List<object> IconCards { get; } = new List<object>
    {
        new { },
        new { },
        new { },
        new { },
        new { },
        new { }
    };

    public CardGridIconControl()
    {
        this.InitializeComponent();
        this.DataContext = this;
    }
}
