using System.Windows.Controls;

namespace SimpleWpfDemo
{
    internal class TicTacToePanel : StackPanel
    {
        public TicTacToePanel()
        {
            Orientation = Orientation.Vertical;

            var panel1 = new StackPanel{Orientation = Orientation.Horizontal};
            panel1.Children.Add(new Button{Content = 1});
            panel1.Children.Add(new Button{Content = 2});
            panel1.Children.Add(new Button{Content = 3});

            var panel2 = new StackPanel { Orientation = Orientation.Horizontal };
            panel2.Children.Add(new Button { Content = 4 });
            panel2.Children.Add(new Button { Content = 5 });
            panel2.Children.Add(new Button { Content = 6 });

            var panel3 = new StackPanel { Orientation = Orientation.Horizontal };
            panel3.Children.Add(new Button { Content = 7 });
            panel3.Children.Add(new Button { Content = 8 });
            panel3.Children.Add(new Button { Content = 9 });

            Children.Add(panel1);
            Children.Add(panel2);
            Children.Add(panel3);

        }
    }
}
