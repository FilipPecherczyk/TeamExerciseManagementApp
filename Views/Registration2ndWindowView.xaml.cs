using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TeamExerciseManagementApp.Views
{
    /// <summary>
    /// Interaction logic for Registration2ndWindowView.xaml
    /// </summary>
    public partial class Registration2ndWindowView : Window
    {
        public Registration2ndWindowView()
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

        private void UserRegistration_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackToFirstPage_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            var newWindow = new RegistrationWindowView();
            newWindow.Show();
        }

        /// <summary>
        /// TextBox rule that allows to write only numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnlyNumbersRule(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        /// <summary>
        /// TextBox rule that allows to write only 3 characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThreeCharsRule(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length > 3)
            {
                textBox.Text = textBox.Text.Substring(0, 3);
                textBox.Select(3, 0);
            }
        }

        /// <summary>
        /// TextBox rule that allows to write only leters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+"); // Allow only alphabets
            e.Handled = regex.IsMatch(e.Text);
        }

        /// <summary>
        /// TextBox rule that allows to write only 20 characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberOfCharsRule(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length > 20)
            {
                textBox.Text = textBox.Text.Substring(0, 20);
                textBox.Select(20, 0);
            }
        }
    }
}
