using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;

namespace figma_design_system_uno.Controls;

public sealed partial class PageProductResultsControl : UserControl
{
    public static readonly DependencyProperty IsMobileProperty = DependencyProperty.Register(
        nameof(IsMobile), typeof(bool), typeof(PageProductResultsControl), new PropertyMetadata(false));

    public bool IsMobile
    {
        get => (bool)GetValue(IsMobileProperty);
        set => SetValue(IsMobileProperty, value);
    }

    public ObservableCollection<ProductItem> Products { get; } = new ObservableCollection<ProductItem>
    {
        new ProductItem { Name = "Text", Price = "$0" },
        new ProductItem { Name = "Text", Price = "$0" },
        new ProductItem { Name = "Text", Price = "$0" },
        new ProductItem { Name = "Text", Price = "$0" },
        new ProductItem { Name = "Text", Price = "$0" },
        new ProductItem { Name = "Text", Price = "$0" },
    };

    public PageProductResultsControl()
    {
        this.InitializeComponent();
        this.DataContext = this;
    }
}

public class ProductItem
{
    public string Name { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
}
