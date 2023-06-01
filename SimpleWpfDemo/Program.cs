using System;
using System.Windows;
using System.Windows.Controls;

namespace SimpleWpfDemo
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();

            // Mer arv
            //var clicker1 = new ClickerPanel();
            //var clicker2 = new ClickerPanel();
            //var clicker3 = new ClickerPanel();

            //var panel = new StackPanel();
            //panel.Children.Add(clicker1);
            //panel.Children.Add(clicker2);
            //panel.Children.Add(clicker3);

            var clicker1 = new Clicker();
            var clicker2 = new Clicker();
            var clicker3 = new Clicker();

            //clicker1._count = 1000;

            var panel = new StackPanel();
            panel.Children.Add(clicker1.Panel);
            panel.Children.Add(clicker2.Panel);
            panel.Children.Add(clicker3.Panel);

            var ticTacToePanel = new TicTacToePanel();
            panel.Children.Add(ticTacToePanel);

            window.Content = panel;
            app.Run(window);
        }
    }
}



