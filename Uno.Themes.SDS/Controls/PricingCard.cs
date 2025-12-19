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

	protected override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		UpdateVisualStates();
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

	public static readonly DependencyProperty IsBrandedProperty = DependencyProperty.Register(
		nameof(IsBranded),
		typeof(bool),
		typeof(PricingCard),
		new PropertyMetadata(false, OnVisualStatePropertyChanged));

	public bool IsBranded
	{
		get => (bool)GetValue(IsBrandedProperty);
		set => SetValue(IsBrandedProperty, value);
	}

	public static readonly DependencyProperty LayoutVariantProperty = DependencyProperty.Register(
		nameof(LayoutVariant),
		typeof(PricingCardLayout),
		typeof(PricingCard),
		new PropertyMetadata(PricingCardLayout.Desktop, OnVisualStatePropertyChanged));

	public PricingCardLayout LayoutVariant
	{
		get => (PricingCardLayout)GetValue(LayoutVariantProperty);
		set => SetValue(LayoutVariantProperty, value);
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

	private static void OnVisualStatePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is PricingCard card)
		{
			card.UpdateVisualStates();
		}
	}

	private void UpdateVisualStates()
	{
		VisualStateManager.GoToState(this, LayoutVariant == PricingCardLayout.Desktop ? "Desktop" : "Mobile", true);
		VisualStateManager.GoToState(this, IsBranded ? "Branded" : "Light", true);
	}
}

public enum PricingCardLayout
{
	Desktop,
	Mobile
}
