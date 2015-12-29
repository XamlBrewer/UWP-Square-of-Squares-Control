﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WinRTXamlToolkit.Controls;
using XamlBrewer.Uwp.Controls;

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
