using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Input;

namespace Uno.Themes.SDS.Controls;

/// <summary>
/// A slider control with two thumbs for selecting a range of values.
/// </summary>
public partial class RangeSlider : Control
{
    private Slider? _minThumb;
    private Slider? _maxThumb;
    private Grid? _rootGrid;
    private bool _isDraggingMin;
    private bool _isDraggingMax;

    public RangeSlider()
    {
        DefaultStyleKey = typeof(RangeSlider);
    }

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();

        // Unhook old events
        if (_minThumb != null)
        {
            _minThumb.ValueChanged -= OnMinThumbValueChanged;
        }
        if (_maxThumb != null)
        {
            _maxThumb.ValueChanged -= OnMaxThumbValueChanged;
        }
        if (_rootGrid != null)
        {
            _rootGrid.PointerPressed -= OnRootGridPointerPressed;
            _rootGrid.PointerMoved -= OnRootGridPointerMoved;
            _rootGrid.PointerReleased -= OnRootGridPointerReleased;
            _rootGrid.PointerCaptureLost -= OnRootGridPointerCaptureLost;
        }

        // Get template parts
        _minThumb = GetTemplateChild("MinThumb") as Slider;
        _maxThumb = GetTemplateChild("MaxThumb") as Slider;
        _rootGrid = GetTemplateChild("RootGrid") as Grid;

        // Hook up events
        if (_minThumb != null)
        {
            _minThumb.ValueChanged += OnMinThumbValueChanged;
        }
        if (_maxThumb != null)
        {
            _maxThumb.ValueChanged += OnMaxThumbValueChanged;
        }
        if (_rootGrid != null)
        {
            _rootGrid.PointerPressed += OnRootGridPointerPressed;
            _rootGrid.PointerMoved += OnRootGridPointerMoved;
            _rootGrid.PointerReleased += OnRootGridPointerReleased;
            _rootGrid.PointerCaptureLost += OnRootGridPointerCaptureLost;
        }
    }

    private void OnMinThumbValueChanged(object sender, RangeBaseValueChangedEventArgs e)
    {
        // Ensure min doesn't go above max
        if (_maxThumb != null && e.NewValue > RangeMax)
        {
            RangeMin = RangeMax;
        }
    }

    private void OnMaxThumbValueChanged(object sender, RangeBaseValueChangedEventArgs e)
    {
        // Ensure max doesn't go below min
        if (_minThumb != null && e.NewValue < RangeMin)
        {
            RangeMax = RangeMin;
        }
    }

    private void OnRootGridPointerPressed(object sender, PointerRoutedEventArgs e)
    {
        if (_minThumb == null || _maxThumb == null || _rootGrid == null)
            return;

        var position = e.GetCurrentPoint(_rootGrid).Position;
        var width = _rootGrid.ActualWidth;
        
        if (width == 0)
            return;

        // Calculate the value at the click position
        var clickValue = Minimum + (position.X / width) * (Maximum - Minimum);

        // Calculate pixel positions of thumbs
        var minThumbPixelPos = ((RangeMin - Minimum) / (Maximum - Minimum)) * width;
        var maxThumbPixelPos = ((RangeMax - Minimum) / (Maximum - Minimum)) * width;
        
        // Calculate pixel distances from click to each thumb
        var pixelDistanceToMin = Math.Abs(position.X - minThumbPixelPos);
        var pixelDistanceToMax = Math.Abs(position.X - maxThumbPixelPos);
        
        // Increased hit zone: 30px on each side of thumb center
        const double hitZone = 30.0;

        // Determine which thumb to move based on proximity
        // If within hit zone of a thumb, prefer that thumb
        // Otherwise, pick the closest one
        bool moveMin = false;
        bool moveMax = false;

        if (pixelDistanceToMin <= hitZone && pixelDistanceToMax <= hitZone)
        {
            // Both thumbs are in range, pick the closer one
            moveMin = pixelDistanceToMin < pixelDistanceToMax;
            moveMax = !moveMin;
        }
        else if (pixelDistanceToMin <= hitZone)
        {
            moveMin = true;
        }
        else if (pixelDistanceToMax <= hitZone)
        {
            moveMax = true;
        }
        else
        {
            // Neither thumb is in hit zone, determine by value distance
            var distanceToMin = Math.Abs(clickValue - RangeMin);
            var distanceToMax = Math.Abs(clickValue - RangeMax);
            moveMin = distanceToMin < distanceToMax;
            moveMax = !moveMin;
        }

        if (moveMin)
        {
            // Start dragging min thumb
            _isDraggingMin = true;
            _isDraggingMax = false;
            Canvas.SetZIndex(_minThumb, 2);
            Canvas.SetZIndex(_maxThumb, 1);
            RangeMin = Math.Clamp(clickValue, Minimum, RangeMax);
        }
        else if (moveMax)
        {
            // Start dragging max thumb
            _isDraggingMax = true;
            _isDraggingMin = false;
            Canvas.SetZIndex(_maxThumb, 2);
            Canvas.SetZIndex(_minThumb, 1);
            RangeMax = Math.Clamp(clickValue, RangeMin, Maximum);
        }

        _rootGrid.CapturePointer(e.Pointer);
        e.Handled = true;
    }

    private void OnRootGridPointerMoved(object sender, PointerRoutedEventArgs e)
    {
        if (_rootGrid == null || (!_isDraggingMin && !_isDraggingMax))
            return;

        var position = e.GetCurrentPoint(_rootGrid).Position;
        var width = _rootGrid.ActualWidth;
        
        if (width == 0)
            return;

        var value = Minimum + (position.X / width) * (Maximum - Minimum);

        if (_isDraggingMin)
        {
            RangeMin = Math.Clamp(value, Minimum, RangeMax);
        }
        else if (_isDraggingMax)
        {
            RangeMax = Math.Clamp(value, RangeMin, Maximum);
        }

        e.Handled = true;
    }

    private void OnRootGridPointerReleased(object sender, PointerRoutedEventArgs e)
    {
        _isDraggingMin = false;
        _isDraggingMax = false;
        
        if (_rootGrid != null)
        {
            _rootGrid.ReleasePointerCapture(e.Pointer);
        }
        
        e.Handled = true;
    }

    private void OnRootGridPointerCaptureLost(object sender, PointerRoutedEventArgs e)
    {
        _isDraggingMin = false;
        _isDraggingMax = false;
    }

    public static readonly DependencyProperty MinimumProperty = DependencyProperty.Register(
        nameof(Minimum),
        typeof(double),
        typeof(RangeSlider),
        new PropertyMetadata(0.0, OnRangeChanged));

    public double Minimum
    {
        get => (double)GetValue(MinimumProperty);
        set => SetValue(MinimumProperty, value);
    }

    public static readonly DependencyProperty MaximumProperty = DependencyProperty.Register(
        nameof(Maximum),
        typeof(double),
        typeof(RangeSlider),
        new PropertyMetadata(100.0, OnRangeChanged));

    public double Maximum
    {
        get => (double)GetValue(MaximumProperty);
        set => SetValue(MaximumProperty, value);
    }

    public static readonly DependencyProperty RangeMinProperty = DependencyProperty.Register(
        nameof(RangeMin),
        typeof(double),
        typeof(RangeSlider),
        new PropertyMetadata(0.0, OnRangeChanged));

    public double RangeMin
    {
        get => (double)GetValue(RangeMinProperty);
        set => SetValue(RangeMinProperty, value);
    }

    public static readonly DependencyProperty RangeMaxProperty = DependencyProperty.Register(
        nameof(RangeMax),
        typeof(double),
        typeof(RangeSlider),
        new PropertyMetadata(100.0, OnRangeChanged));

    public double RangeMax
    {
        get => (double)GetValue(RangeMaxProperty);
        set => SetValue(RangeMaxProperty, value);
    }

    private static void OnRangeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RangeSlider slider)
        {
            slider.UpdateVisualState();
        }
    }

    private void UpdateVisualState()
    {
        // Visual state update will be handled by the template
    }
}
