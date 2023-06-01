using System;
using System.Windows.Controls;
using System.Windows;

namespace SimpleWpfDemo
{
    internal class OldProgram
    {
        private static Label _label;
        private static int count = 0;

        [STAThread]
        public static void Mainx(string[] args)
        {
            var app = new Application();
            var window = new Window();

            var button = new Button { Content = "Trykk her!" };
            button.Click += ButtonClick;
            _label = new Label { Content = "0" };
            var panel = new StackPanel();
            panel.Children.Add(button);
            panel.Children.Add(_label);
            window.Content = panel;

            app.Run(window);
        }

        private static void ButtonClick(object sender, RoutedEventArgs e)
        {
            count++;
            _label.Content = count;
        }
    }
}
