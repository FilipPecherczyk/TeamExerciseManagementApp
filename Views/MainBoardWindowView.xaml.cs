using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TeamExerciseManagementApp.Models.DataBaseOperations;
using TeamExerciseManagementApp.ViewModels;

namespace TeamExerciseManagementApp.Views
{
    /// <summary>
    /// Interaction logic for MainBoardWindowView.xaml
    /// </summary>
    public partial class MainBoardWindowView : Window
    {
        public MainBoardWindowView()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
            SetBoardContent();

            if (!IsUserCoach())
            {
                GroupResults_btn.Visibility = Visibility.Hidden;
            }
        }

        private void CloseApp_btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizeApp_btn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        /// <summary>
        /// Simulate button click to display profile content
        /// </summary>
        private void SetBoardContent()
        {
            ButtonAutomationPeer peer = new ButtonAutomationPeer(ProfileContent_btn);
            IInvokeProvider invokeProv = peer.GetPattern(PatternInterface.Invoke) as IInvokeProvider;
            invokeProv.Invoke();
        }

        private bool IsUserCoach()
        {
            if (UserLogin.LogedUser.UserCategory == Enums.UserCategories.Coach)
            {
                return true;
            }

            return false;
        }
    }
}
