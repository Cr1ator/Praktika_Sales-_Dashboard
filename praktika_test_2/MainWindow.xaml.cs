﻿using System.Windows;
using System.Windows.Input;

namespace praktika_test_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton==MouseButton.Left) 
            { 
                this.DragMove();
            }
        }

        bool IsMaximized= false;

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (this.IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1280;
                    this.Height = 780;

                    this.IsMaximized = false;
                }
                else
                {
                    this.WindowState= WindowState.Maximized;

                    this.IsMaximized = true;
                }
            }
        }
    }
}
