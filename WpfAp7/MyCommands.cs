using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAp7
{
    internal class MyCommands
    {
        public static RoutedUICommand Exit { get; set; }
        public static RoutedCommand Bold { get; set; }
        public static RoutedCommand Italic { get; set; }
        public static RoutedCommand Underline { get; set; }

        static MyCommands()
        {
            InputGestureCollection boldInput = new InputGestureCollection();
            boldInput.Add(new KeyGesture(Key.B, ModifierKeys.Control));
            InputGestureCollection italicInput = new InputGestureCollection();
            italicInput.Add(new KeyGesture(Key.I, ModifierKeys.Control));
            InputGestureCollection underlineInput = new InputGestureCollection();
            underlineInput.Add(new KeyGesture(Key.L, ModifierKeys.Control));
            Exit = new RoutedUICommand("Выход", "Exit", typeof(MyCommands));
            Bold = new RoutedCommand("Bold", typeof(MyCommands), boldInput);
            Italic = new RoutedCommand("Italic", typeof(MyCommands), italicInput);
            Underline = new RoutedCommand("Underline", typeof(MyCommands), underlineInput);
        }
    }
}
