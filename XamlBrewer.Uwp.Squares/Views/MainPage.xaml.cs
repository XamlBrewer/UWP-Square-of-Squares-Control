﻿using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using XamlBrewer.Uwp.Controls;

namespace XamlBrewer.Uwp.Squares
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var square in SquareOfSquares.Squares)
            {
                var grid = new Grid() { Height = square.ActualHeight, Width = square.ActualWidth };
                grid.Background = new SolidColorBrush(square.RandomColor());
                var side = square.Side().ToString();
                grid.Children.Add(new TextBlock() { Text = side, Margin = new Thickness(2.0, 1.0, 0.0, 0.0), Foreground = new SolidColorBrush(Colors.White) });
                square.Content = grid;
            }
        }
    }
}
