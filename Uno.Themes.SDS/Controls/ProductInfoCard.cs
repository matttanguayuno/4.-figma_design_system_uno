using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Uno.Themes.SDS.Controls;

public partial class ProductInfoCard : Control
{
	public ProductInfoCard()
	{
		DefaultStyleKey = typeof(ProductInfoCard);
	}

	public static readonly DependencyProperty ProductNameProperty = DependencyProperty.Register(
		nameof(ProductName),
		typeof(string),
		typeof(ProductInfoCard),
		new PropertyMetadata("Text"));

	public string ProductName
	{
		get => (string)GetValue(ProductNameProperty);
		set => SetValue(ProductNameProperty, value);
	}

	public static readonly DependencyProperty PriceProperty = DependencyProperty.Register(
		nameof(Price),
		typeof(string),
		typeof(ProductInfoCard),
		new PropertyMetadata("$0"));

	public string Price
	{
		get => (string)GetValue(PriceProperty);
		set => SetValue(PriceProperty, value);
	}

	public static readonly DependencyProperty DescriptionProperty = DependencyProperty.Register(
		nameof(Description),
		typeof(string),
		typeof(ProductInfoCard),
		new PropertyMetadata("Body text."));

	public string Description
	{
		get => (string)GetValue(DescriptionProperty);
		set => SetValue(DescriptionProperty, value);
	}

	public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register(
		nameof(ImageSource),
		typeof(string),
		typeof(ProductInfoCard),
		new PropertyMetadata(null));

	public string ImageSource
	{
		get => (string)GetValue(ImageSourceProperty);
		set => SetValue(ImageSourceProperty, value);
	}
}
