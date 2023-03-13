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

namespace TeamExerciseManagementApp.Views
{
    /// <summary>
    /// Interaction logic for RegistrationWindowView.xaml
    /// </summary>
    public partial class RegistrationWindowView : Window
    {
        public RegistrationWindowView()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseApp_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimizeApp_btn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }


        private void NextRegistrationPage_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            var newWindow = new Registration2ndWindowView();
            newWindow.Show();
        }
    }
}
