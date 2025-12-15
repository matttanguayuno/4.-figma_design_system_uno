using Microsoft.UI.Xaml.Controls;

namespace figma_design_system_uno.Presentation
{
    public sealed partial class TagTogglePage : Page
    {
        public TagTogglePage()
        {
            this.InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
