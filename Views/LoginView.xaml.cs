using System;
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
using System.Windows.Shapes;
using TeamExerciseManagementApp.Models.DataBaseOperations;

namespace TeamExerciseManagementApp.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
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

        private void MinimizeApp_btn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseApp_btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
            var login = UserName_txt.Text;
            var password = UserPassword_txt.Password;
            if (UserLogin.CanUserBeLogged(login,password))
            {
                this.Visibility = Visibility.Hidden;
                var newWindow = new MainBoardWindowView();
                newWindow.Show();
            }
            else
            {
                Login_btn.Background = Brushes.Red;
                WrongLogingOrPassword_textBlock.Visibility = Visibility.Visible;
            }

        }

        private void Register_btn_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new RegistrationWindowView();
            newWindow.Show();
        }
    }
}
