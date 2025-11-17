using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

namespace figma_design_system_uno.Presentation
{
    public sealed partial class TagDemoTag : UserControl
    {
        public static readonly DependencyProperty ShowCloseProperty = DependencyProperty.Register(
            nameof(ShowClose), typeof(bool), typeof(TagDemoTag), new PropertyMetadata(true));

        public static readonly DependencyProperty BackgroundBrushProperty = DependencyProperty.Register(
            nameof(BackgroundBrush), typeof(Brush), typeof(TagDemoTag), new PropertyMetadata(null));

        public static readonly DependencyProperty ForegroundBrushProperty = DependencyProperty.Register(
            nameof(ForegroundBrush), typeof(Brush), typeof(TagDemoTag), new PropertyMetadata(null));

        public bool ShowClose
        {
            get => (bool)GetValue(ShowCloseProperty);
            set => SetValue(ShowCloseProperty, value);
        }

        public Brush BackgroundBrush
        {
            get => (Brush)GetValue(BackgroundBrushProperty);
            set => SetValue(BackgroundBrushProperty, value);
        }

        public Brush ForegroundBrush
        {
            get => (Brush)GetValue(ForegroundBrushProperty);
            set => SetValue(ForegroundBrushProperty, value);
        }

        public TagDemoTag()
        {
            this.InitializeComponent();
        }
    }
}
