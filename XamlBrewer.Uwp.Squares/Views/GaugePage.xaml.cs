using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using XamlBrewer.Uwp.Controls;
using WinRTXamlToolkit.Controls;

namespace XamlBrewer.Uwp.Squares
{
    public sealed partial class GaugePage : Page
    {
        public GaugePage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var square in SquareOfSquares.Squares)
            {
                var gauge = new Gauge() { Height = square.ActualHeight, Width = square.ActualWidth };
                //grid.Background = new SolidColorBrush(square.RandomColor());
                var side = square.Side();
                gauge.Value = side;
                square.Content = gauge;
            }
        }
    }
}
