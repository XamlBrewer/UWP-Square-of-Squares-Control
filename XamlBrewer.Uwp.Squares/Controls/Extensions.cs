using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace XamlBrewer.Uwp.Controls
{
    public static class Extensions
    {
        private static Random r = new Random(DateTime.Now.Millisecond);

        public static int Side(this UIElement element)
        {
            return (int)element.GetValue(Grid.RowSpanProperty);
        }

        public static Color RandomColor(this UIElement element)
        {
            byte red = (byte)r.Next(0, 255);
            byte green = (byte)r.Next(0, 255);
            byte blue = (byte)r.Next(0, 255);

            return new Color() { A = 255, R = red, G = green, B = blue };
        }
    }
}
