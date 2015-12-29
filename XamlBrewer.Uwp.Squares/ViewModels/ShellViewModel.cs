using Windows.UI.Xaml.Controls;
using XamlBrewer.Uwp.Squares;

namespace Mvvm
{
    class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            // Build the menu
            // Symbol enumeration is here: https://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.controls.symbol.aspx
            Menu.Add(new MenuItem() { Glyph = Symbol.Edit, Text = "Colors", NavigationDestination = typeof(MainPage) });
            Menu.Add(new MenuItem() { Glyph = Symbol.Rotate, Text = "Gauges", NavigationDestination = typeof(GaugePage) });
            Menu.Add(new MenuItem() { Glyph = Symbol.Clock, Text = "Clocks", NavigationDestination = typeof(ClockPage) });
        }
    }
}
