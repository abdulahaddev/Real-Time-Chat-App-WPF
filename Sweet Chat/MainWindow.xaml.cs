using System;
using System.Windows;
using System.Windows.Input;

namespace Sweet_Chat
{
    public partial class MainWindow : Window
    {
        private Window RootWindow => Application.Current.MainWindow;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            switch (RootWindow.WindowState)
            {
                case WindowState.Normal:
                    RootWindow.WindowState = WindowState.Maximized;
                    break;
                case WindowState.Maximized:
                    RootWindow.WindowState = WindowState.Normal;
                    break;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            RootWindow.WindowState = WindowState.Minimized;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
            if (e.ClickCount == 2)
            {
                switch (RootWindow.WindowState)
                {
                    case WindowState.Normal:
                        RootWindow.WindowState = WindowState.Maximized;
                        break;
                    case WindowState.Maximized:
                        RootWindow.WindowState = WindowState.Normal;
                        break;
                }
            }
        }
    }
}
