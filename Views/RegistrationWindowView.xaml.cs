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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TeamExerciseManagementApp.Enums;
using TeamExerciseManagementApp.Models.DataBaseOperations;

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

            _CanGoToNextRegistryPageFlag = false;
            UserCategories_ComboBox.ItemsSource = Enum.GetValues(typeof(UserCategories));
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


        private bool _CanGoToNextRegistryPageFlag = false;
        private void NextRegistrationPage_btn_Click(object sender, RoutedEventArgs e)
        {
            //Check if all of functions are field
            if (UserLoginToRegistry_txt.Text.Length > 0 && User1stPasswordToRegistry_txt.Password.Length > 0
                && (UserCategories_ComboBox.SelectedIndex == 0 || UserCategories_ComboBox.SelectedIndex == 1))
            {
                _CanGoToNextRegistryPageFlag = true;
            }


            if (_CanGoToNextRegistryPageFlag)
            {
                UserRegistrationToDataBase.UserToRegistration.Login = UserLoginToRegistry_txt.Text;
                UserRegistrationToDataBase.UserToRegistration.Password = User1stPasswordToRegistry_txt.Password;
                if (UserCategories_ComboBox.SelectedItem.ToString() == "Player")
                {
                    UserRegistrationToDataBase.UserToRegistration.UserCategory = UserCategories.Player;
                }
                if (UserCategories_ComboBox.SelectedItem.ToString() == "Coach")
                {
                    UserRegistrationToDataBase.UserToRegistration.UserCategory = UserCategories.Coach;
                }
                this.Visibility = Visibility.Hidden;
                var newWindow = new Registration2ndWindowView();
                newWindow.Show();
            }
            else
            {
                WrongUserRegistration_text.Visibility = Visibility.Visible;
            }

        }

    }
}
