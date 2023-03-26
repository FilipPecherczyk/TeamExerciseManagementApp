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
using TeamExerciseManagementApp.Models.DataBaseOperations;

namespace TeamExerciseManagementApp.BoardContentViews
{
    /// <summary>
    /// Interaction logic for ProfileContentView.xaml
    /// </summary>
    public partial class ProfileContentView : UserControl
    {
        public ProfileContentView()
        {
            InitializeComponent();

            UserLastname.Text = UserLogin.LogedUser.LastName;
            UserName.Text = UserLogin.LogedUser.FirstName;
            UserHeight.Text = UserLogin.LogedUser.Results_ID.Height.ToString() + "cm";
            UserWeight.Text = UserLogin.LogedUser.Results_ID.Weight.ToString() + "kg";
            UserBirthday.Text = UserLogin.LogedUser.Birthday.ToString() + "r.";
            UserCategory.Text = UserLogin.LogedUser.UserCategory.ToString();
        }
    }
}
