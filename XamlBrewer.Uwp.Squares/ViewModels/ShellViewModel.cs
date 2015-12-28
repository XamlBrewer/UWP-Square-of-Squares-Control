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
            //Menu.Add(new MenuItem() { Glyph = Symbol.OutlineStar, Text = "Classic", NavigationDestination = typeof(OtherPage) });
            //Menu.Add(new MenuItem() { Glyph = Symbol.Emoji, Text = "Silly", NavigationDestination = typeof(SillyPage) });
        }
    }
}
