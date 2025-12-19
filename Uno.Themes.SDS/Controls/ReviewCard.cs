using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;

namespace Uno.Themes.SDS.Controls;

public partial class ReviewCard : Control
{
	public ReviewCard()
	{
		DefaultStyleKey = typeof(ReviewCard);
	}

	protected override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		UpdateRatingVisualState();
		UpdateReviewerImage();
	}

	public static readonly DependencyProperty RatingProperty = DependencyProperty.Register(
		nameof(Rating),
		typeof(int),
		typeof(ReviewCard),
		new PropertyMetadata(5, OnRatingChanged));

	public int Rating
	{
		get => (int)GetValue(RatingProperty);
		set => SetValue(RatingProperty, value);
	}

	private static void OnRatingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is ReviewCard card)
		{
			card.UpdateRatingVisualState();
		}
	}

	private void UpdateRatingVisualState()
	{
		var rating = Math.Clamp(Rating, 0, 5);
		if (rating > 0)
		{
			VisualStateManager.GoToState(this, $"Rating{rating}", true);
		}
	}

	public static readonly DependencyProperty ReviewTitleProperty = DependencyProperty.Register(
		nameof(ReviewTitle),
		typeof(string),
		typeof(ReviewCard),
		new PropertyMetadata("Review title"));

	public string ReviewTitle
	{
		get => (string)GetValue(ReviewTitleProperty);
		set => SetValue(ReviewTitleProperty, value);
	}

	public static readonly DependencyProperty ReviewBodyProperty = DependencyProperty.Register(
		nameof(ReviewBody),
		typeof(string),
		typeof(ReviewCard),
		new PropertyMetadata("Review body"));

	public string ReviewBody
	{
		get => (string)GetValue(ReviewBodyProperty);
		set => SetValue(ReviewBodyProperty, value);
	}

	public static readonly DependencyProperty ReviewerNameProperty = DependencyProperty.Register(
		nameof(ReviewerName),
		typeof(string),
		typeof(ReviewCard),
		new PropertyMetadata("Reviewer name"));

	public string ReviewerName
	{
		get => (string)GetValue(ReviewerNameProperty);
		set => SetValue(ReviewerNameProperty, value);
	}

	public static readonly DependencyProperty ReviewDateProperty = DependencyProperty.Register(
		nameof(ReviewDate),
		typeof(string),
		typeof(ReviewCard),
		new PropertyMetadata("Date"));

	public string ReviewDate
	{
		get => (string)GetValue(ReviewDateProperty);
		set => SetValue(ReviewDateProperty, value);
	}

	public static readonly DependencyProperty ReviewerImageProperty = DependencyProperty.Register(
		nameof(ReviewerImage),
		typeof(string),
		typeof(ReviewCard),
		new PropertyMetadata("https://picsum.photos/id/64/40/40", OnReviewerImageChanged));

	public string ReviewerImage
	{
		get => (string)GetValue(ReviewerImageProperty);
		set => SetValue(ReviewerImageProperty, value);
	}

	private static void OnReviewerImageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is ReviewCard card)
		{
			card.UpdateReviewerImage();
		}
	}

	private void UpdateReviewerImage()
	{
		if (GetTemplateChild("ReviewerImageBrush") is ImageBrush brush && !string.IsNullOrEmpty(ReviewerImage))
		{
			brush.ImageSource = new BitmapImage(new Uri(ReviewerImage));
		}
	}
}
