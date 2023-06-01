using System.Windows.Controls;
using System.Windows;

namespace SimpleWpfDemo
{
    internal class ClickerPanel : StackPanel
    {
        private Label _label;
        private int _count = 0;

        public ClickerPanel()
        {
            var button = new Button
            {
                Content = "Trykk her!",
                Width = 200
            };
            button.Click += ButtonClick;
            _label = new Label { Content = "0" };
            Orientation = Orientation.Horizontal;
            Children.Add(button);
            Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
