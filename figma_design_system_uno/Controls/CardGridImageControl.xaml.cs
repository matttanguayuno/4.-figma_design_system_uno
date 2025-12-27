using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;

namespace figma_design_system_uno.Controls;

public sealed partial class CardGridImageControl : UserControl
{
    public static readonly DependencyProperty IsMobileProperty =
        DependencyProperty.Register(
            nameof(IsMobile),
            typeof(bool),
            typeof(CardGridImageControl),
            new PropertyMetadata(false));

    public bool IsMobile
    {
        get => (bool)GetValue(IsMobileProperty);
        set => SetValue(IsMobileProperty, value);
    }

    public List<object> ImageCards { get; } = new List<object>
    {
        new { },
        new { },
        new { },
        new { },
        new { },
        new { }
    };

    public CardGridImageControl()
    {
        this.InitializeComponent();
        this.DataContext = this;
    }
}
