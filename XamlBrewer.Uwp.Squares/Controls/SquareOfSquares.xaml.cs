﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace XamlBrewer.Uwp.Controls
{
    public sealed partial class SquareOfSquares : UserControl
    {
        private Random r = new Random(DateTime.Now.Millisecond);

        public SquareOfSquares()
        {
            this.InitializeComponent();

            Root.RowDefinitions.Clear();
            Root.RowDefinitions.Clear();

            for (int i = 0; i < 112; i++)
            {
                Root.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
                Root.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            }

            foreach (InnerSquare square in GetSquares())
            {
                var ctl = new ContentControl(); // { Stretch = Stretch.UniformToFill };
                ctl.SetValue(Grid.RowProperty, square.Position.Y);
                ctl.SetValue(Grid.ColumnProperty, square.Position.X);
                ctl.SetValue(Grid.ColumnSpanProperty, square.Side);
                ctl.SetValue(Grid.RowSpanProperty, square.Side);
                //var cc = new ContentControl();
                //cc.VerticalAlignment = VerticalAlignment.Stretch;
                //cc.HorizontalAlignment = HorizontalAlignment.Stretch;
                //cc.VerticalAlignment = VerticalAlignment.Stretch;
                //cc.HorizontalAlignment = HorizontalAlignment.Stretch;
                //ctl.Child = cc;
                Root.Children.Add(ctl);
                Squares.Add(ctl);
            }
        }

        public List<ContentControl> Squares { get; private set; } = new List<ContentControl>();

        public Color RandomColor()
        {
            byte red = (byte)r.Next(0, 255);
            byte green = (byte)r.Next(0, 255);
            byte blue = (byte)r.Next(0, 255);

            return new Color() { A = 255, R = red, G = green, B = blue };
        }

        private List<InnerSquare> GetSquares()
        {
            var list = new List<InnerSquare>();

            list.Add(new InnerSquare() { Position = new Point(0, 0), Side = 50 });
            list.Add(new InnerSquare() { Position = new Point(50, 0), Side = 35 });
            list.Add(new InnerSquare() { Position = new Point(85, 0), Side = 27 });
            list.Add(new InnerSquare() { Position = new Point(85, 27), Side = 8 });
            list.Add(new InnerSquare() { Position = new Point(93, 27), Side = 19 });
            list.Add(new InnerSquare() { Position = new Point(50, 35), Side = 15 });
            list.Add(new InnerSquare() { Position = new Point(65, 35), Side = 17 });
            list.Add(new InnerSquare() { Position = new Point(82, 35), Side = 11 });
            list.Add(new InnerSquare() { Position = new Point(82, 46), Side = 6 });
            list.Add(new InnerSquare() { Position = new Point(88, 46), Side = 24 });
            list.Add(new InnerSquare() { Position = new Point(0, 50), Side = 29 });
            list.Add(new InnerSquare() { Position = new Point(29, 50), Side = 25 });
            list.Add(new InnerSquare() { Position = new Point(54, 50), Side = 9 });
            list.Add(new InnerSquare() { Position = new Point(63, 50), Side = 2 });
            list.Add(new InnerSquare() { Position = new Point(63, 52), Side = 7 });
            list.Add(new InnerSquare() { Position = new Point(70, 52), Side = 18 });
            list.Add(new InnerSquare() { Position = new Point(54, 59), Side = 16 });
            list.Add(new InnerSquare() { Position = new Point(70, 70), Side = 42 });
            list.Add(new InnerSquare() { Position = new Point(29, 75), Side = 4 });
            list.Add(new InnerSquare() { Position = new Point(33, 75), Side = 37 });
            list.Add(new InnerSquare() { Position = new Point(0, 79), Side = 33 });

            return list;
        }

        private class InnerSquare
        {
            public Point Position { get; set; }
            public int Side { get; set; }
        }
    }
}
