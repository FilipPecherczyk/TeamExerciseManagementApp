using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamExerciseManagementApp.Models.UserEntities;

namespace TeamExerciseManagementApp.Models.DataBaseOperations
{
    public static class UserLogin
    {
        public static User LogedUser { get; set; }

        public static bool CanUserBeLogged(string userLogin, string userPassword)
        {
            SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=TeamDataBase");

            String querry = $"SELECT * FROM Users WHERE Login = '{userLogin}' AND Password = '{userPassword}'";
            SqlDataAdapter adapter = new SqlDataAdapter(querry,conn);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);


            if (dataTable.Rows.Count > 0)
            {
                var dbContext = new Context();
                var user = dbContext.Users.Where(u => u.Login == userLogin).ToList();
                var loggedUserID = user[0].User_ID;
                var userResults = dbContext.PlayerResults.Where(uR => uR.Results_ID == loggedUserID).ToList();

                // PlayerResults object to add to Results_ID
                var helperPlayerResult = new PlayerResults
                {
                    Results_ID = userResults[0].Results_ID,
                    Weight = userResults[0].Weight,
                    Height = userResults[0].Height,
                    BenchPress = userResults[0].BenchPress,
                    Squats = userResults[0].Squats,
                    Deadlift = userResults[0].Deadlift,
                    Run60 = userResults[0].Run60,
                    Jump = userResults[0].Jump
                };

                var userHelper = new User
                {
                    User_ID = loggedUserID,
                    FirstName = user[0].FirstName,
                    LastName = user[0].LastName,
                    UserCategory = user[0].UserCategory,
                    Birthday = user[0].Birthday,
                    Login = user[0].Login,
                    Password = user[0].Password,
                    Results_ID = helperPlayerResult
                };
                    LogedUser = userHelper;
                return true;
            }
            else
            {
                return false;
            }
        }

         
    }
}
