using System.Collections.Generic;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

namespace Uno.Themes.SDS.Controls;

public partial class PricingCard : Control
{
	public PricingCard()
	{
		DefaultStyleKey = typeof(PricingCard);
	}

	public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
		nameof(Title),
		typeof(string),
		typeof(PricingCard),
		new PropertyMetadata("Title"));

	public string Title
	{
		get => (string)GetValue(TitleProperty);
		set => SetValue(TitleProperty, value);
	}

	public static readonly DependencyProperty PriceProperty = DependencyProperty.Register(
		nameof(Price),
		typeof(string),
		typeof(PricingCard),
		new PropertyMetadata("50"));

	public string Price
	{
		get => (string)GetValue(PriceProperty);
		set => SetValue(PriceProperty, value);
	}

	public static readonly DependencyProperty PeriodProperty = DependencyProperty.Register(
		nameof(Period),
		typeof(string),
		typeof(PricingCard),
		new PropertyMetadata(" / mo"));

	public string Period
	{
		get => (string)GetValue(PeriodProperty);
		set => SetValue(PeriodProperty, value);
	}

	public static readonly DependencyProperty FeaturesProperty = DependencyProperty.Register(
		nameof(Features),
		typeof(IList<string>),
		typeof(PricingCard),
		new PropertyMetadata(null));

	public IList<string> Features
	{
		get => (IList<string>)GetValue(FeaturesProperty);
		set => SetValue(FeaturesProperty, value);
	}

	public static readonly DependencyProperty ButtonTextProperty = DependencyProperty.Register(
		nameof(ButtonText),
		typeof(string),
		typeof(PricingCard),
		new PropertyMetadata("Button"));

	public string ButtonText
	{
		get => (string)GetValue(ButtonTextProperty);
		set => SetValue(ButtonTextProperty, value);
	}

	public static readonly DependencyProperty ButtonBackgroundProperty = DependencyProperty.Register(
		nameof(ButtonBackground),
		typeof(Brush),
		typeof(PricingCard),
		new PropertyMetadata(null));

	public Brush ButtonBackground
	{
		get => (Brush)GetValue(ButtonBackgroundProperty);
		set => SetValue(ButtonBackgroundProperty, value);
	}

	public static readonly DependencyProperty ButtonForegroundProperty = DependencyProperty.Register(
		nameof(ButtonForeground),
		typeof(Brush),
		typeof(PricingCard),
		new PropertyMetadata(null));

	public Brush ButtonForeground
	{
		get => (Brush)GetValue(ButtonForegroundProperty);
		set => SetValue(ButtonForegroundProperty, value);
	}

	public static readonly DependencyProperty ButtonBorderBrushProperty = DependencyProperty.Register(
		nameof(ButtonBorderBrush),
		typeof(Brush),
		typeof(PricingCard),
		new PropertyMetadata(null));

	public Brush ButtonBorderBrush
	{
		get => (Brush)GetValue(ButtonBorderBrushProperty);
		set => SetValue(ButtonBorderBrushProperty, value);
	}
}
