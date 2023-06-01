using System;
using System.Windows;
using System.Windows.Controls;

namespace SimpleWpfDemo
{
    internal class Program
    {
        private static Label label;

        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var button = new Button {Content = "Trykk her!"};
            button.Click += ButtonClick;
            label = new Label {Content = "0"};
            var panel = new StackPanel();
            panel.Children.Add(button);
            panel.Children.Add(label);
            window.Content = panel;
            app.Run(window);
        }

        private static void ButtonClick(object sender, RoutedEventArgs e)
        {
            //count++;
            label.Content = "Du har trykket";
        }
    }
}



