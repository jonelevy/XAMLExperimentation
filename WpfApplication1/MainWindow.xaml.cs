﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
       
        bool stop = false;
        public MainWindow()
        {

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (stop == false)
            {
                Box.Text = "Stop That!";
                stop = true;
                theButton.Background = Brushes.Red;
                theButton.Foreground = Brushes.White;
                
            }
            else if (stop == true)
            {
                Box.Text = String.Empty;//sets the textbox string to empty
                stop = false;
                theButton.Background = Brushes.Green;
                theButton.Foreground = Brushes.Black;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            theOutput.Text = nameInput.Text + ", now that's a name!";
            nameInput.Text = String.Empty;
        }
    }
}
