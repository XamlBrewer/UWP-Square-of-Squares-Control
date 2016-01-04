using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using XamlBrewer.Uwp.Controls;

namespace XamlBrewer.Uwp.Squares
{
    public sealed partial class ClockPage : Page
    {
        public ClockPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var square in SquareOfSquares.Squares)
            {
                var clock = new Clock() { Height = square.ActualHeight, Width = square.ActualWidth };
                square.Content = clock;
            }
        }
    }
}
