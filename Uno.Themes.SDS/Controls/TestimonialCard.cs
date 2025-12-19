using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;

namespace Uno.Themes.SDS.Controls;

public partial class TestimonialCard : Control
{
	public TestimonialCard()
	{
		DefaultStyleKey = typeof(TestimonialCard);
	}

	protected override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		UpdateAuthorImage();
	}

	public static readonly DependencyProperty QuoteProperty = DependencyProperty.Register(
		nameof(Quote),
		typeof(string),
		typeof(TestimonialCard),
		new PropertyMetadata("\"Quote\""));

	public string Quote
	{
		get => (string)GetValue(QuoteProperty);
		set => SetValue(QuoteProperty, value);
	}

	public static readonly DependencyProperty AuthorNameProperty = DependencyProperty.Register(
		nameof(AuthorName),
		typeof(string),
		typeof(TestimonialCard),
		new PropertyMetadata("Title"));

	public string AuthorName
	{
		get => (string)GetValue(AuthorNameProperty);
		set => SetValue(AuthorNameProperty, value);
	}

	public static readonly DependencyProperty AuthorTitleProperty = DependencyProperty.Register(
		nameof(AuthorTitle),
		typeof(string),
		typeof(TestimonialCard),
		new PropertyMetadata("Description"));

	public string AuthorTitle
	{
		get => (string)GetValue(AuthorTitleProperty);
		set => SetValue(AuthorTitleProperty, value);
	}

	public static readonly DependencyProperty AuthorImageProperty = DependencyProperty.Register(
		nameof(AuthorImage),
		typeof(string),
		typeof(TestimonialCard),
		new PropertyMetadata("https://picsum.photos/id/65/40/40", OnAuthorImageChanged));

	public string AuthorImage
	{
		get => (string)GetValue(AuthorImageProperty);
		set => SetValue(AuthorImageProperty, value);
	}

	private static void OnAuthorImageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is TestimonialCard card)
		{
			card.UpdateAuthorImage();
		}
	}

	private void UpdateAuthorImage()
	{
		if (GetTemplateChild("AuthorImageBrush") is ImageBrush brush && !string.IsNullOrEmpty(AuthorImage))
		{
			brush.ImageSource = new BitmapImage(new Uri(AuthorImage));
		}
	}
}
