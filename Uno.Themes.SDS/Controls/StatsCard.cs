using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Uno.Themes.SDS.Controls;

public partial class StatsCard : Control
{
	public StatsCard()
	{
		DefaultStyleKey = typeof(StatsCard);
	}

	public static readonly DependencyProperty IconGlyphProperty = DependencyProperty.Register(
		nameof(IconGlyph),
		typeof(string),
		typeof(StatsCard),
		new PropertyMetadata("&#xE823;"));

	public string IconGlyph
	{
		get => (string)GetValue(IconGlyphProperty);
		set => SetValue(IconGlyphProperty, value);
	}

	public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
		nameof(Value),
		typeof(string),
		typeof(StatsCard),
		new PropertyMetadata("100"));

	public string Value
	{
		get => (string)GetValue(ValueProperty);
		set => SetValue(ValueProperty, value);
	}

	public static readonly DependencyProperty LabelProperty = DependencyProperty.Register(
		nameof(Label),
		typeof(string),
		typeof(StatsCard),
		new PropertyMetadata("Body text"));

	public string Label
	{
		get => (string)GetValue(LabelProperty);
		set => SetValue(LabelProperty, value);
	}
}
