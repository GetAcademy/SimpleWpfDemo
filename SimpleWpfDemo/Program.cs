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
            // Pause til 13:33

            var app = new Application();
            var window = new Window();

            var clicker1 = new Clicker();
            var clicker2 = new Clicker();
            var clicker3 = new Clicker();

            var panel = new StackPanel();
            panel.Children.Add(clicker1.Panel);
            panel.Children.Add(clicker2.Panel);
            panel.Children.Add(clicker3.Panel);

            window.Content = panel;
            app.Run(window);
        }
    }
}



