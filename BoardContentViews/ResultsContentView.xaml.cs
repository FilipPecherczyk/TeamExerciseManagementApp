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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TeamExerciseManagementApp.BoardContentViews
{
    /// <summary>
    /// Interaction logic for ResultsContentView.xaml
    /// </summary>
    public partial class ResultsContentView : UserControl
    {
        public ResultsContentView()
        {
            InitializeComponent();
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

        //Dopisać aktualizacje bazy danych
        private void Save_btn_Click(object sender, RoutedEventArgs e)
        {
            Chest_kg.IsReadOnly = true;
            Squat_kg.IsReadOnly = true;
            Deadlift_kg.IsReadOnly = true;
            Run_time.IsReadOnly = true;
            Jump_meters.IsReadOnly = true;

            Save_btn.Visibility = Visibility.Hidden;
        }

        private void AllowToEdit_btn_Click(object sender, RoutedEventArgs e)
        {
            Chest_kg.IsReadOnly = false;
            Squat_kg.IsReadOnly = false;    
            Deadlift_kg.IsReadOnly = false;
            Run_time.IsReadOnly = false;
            Jump_meters.IsReadOnly = false;

            Save_btn.Visibility = Visibility.Visible;
        }
    }
}
