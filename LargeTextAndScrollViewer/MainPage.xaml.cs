using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace LargeTextAndScrollViewer
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var bounds = Window.Current.Bounds;
            InnerStackPanel.Width = bounds.Width;
        }
    }
}
