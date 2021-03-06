﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread t = new Thread(this.ThreadProcedure);
            t.Start();
        }

        private void ThreadProcedure(object state)
        {
            throw new Exception("Oh noooo!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            throw new Exception("Oh noooo!");
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            await AsyncProcedure();
        }

        private async Task AsyncProcedure()
        {
            throw new Exception("Oh noooo!");
        }
    }
}
