﻿using Mvvm.Services;
using XamlBrewer.Uwp.ImplicitAnimation;

namespace Mvvm
{
    internal class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            // Build the menus
            Menu.Add(new MenuItem() { Glyph = Icon.GetIcon("SeaHorseIcon"), Text = "Main", NavigationDestination = typeof(MainPage) });

            SecondMenu.Add(new MenuItem() { Glyph = Icon.GetIcon("InfoIcon"), Text = "About", NavigationDestination = typeof(AboutPage) });
        }
    }
}
