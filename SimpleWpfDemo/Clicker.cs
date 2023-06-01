using System.Windows;
using System.Windows.Controls;

namespace SimpleWpfDemo
{
    internal class Clicker
    {
        private Label _label;
        private int _count = 0;
        public StackPanel Panel { get; }

        public Clicker()
        {
            var button = new Button { Content = "Trykk her!" };
            button.Click += ButtonClick;
            _label = new Label { Content = "0" };
            Panel = new StackPanel
            {
                Orientation = Orientation.Horizontal
            };
            Panel.Children.Add(button);
            Panel.Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
            //var button = (Button)sender;
            //button.Content = "du har trykket";
        }
    }
}
