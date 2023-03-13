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

                var userHelper = new User
                {
                    User_ID = user[0].User_ID,
                    FirstName = user[0].FirstName,
                    LastName = user[0].LastName,
                    UserCategory = user[0].UserCategory,
                    Birthday = user[0].Birthday,
                    Login = user[0].Login,
                    Password = user[0].Password,
                    Results_ID = user[0].Results_ID
                    //Results_ID = new PlayerResults
                    //{
                    //    Results_ID = user[0].Results_ID.Results_ID,
                    //    Weight = user[0].Results_ID.Weight,
                    //    Height = user[0].Results_ID.Height,
                    //    BenchPress = user[0].Results_ID.BenchPress,
                    //    Squats = user[0].Results_ID.Squats,
                    //    Deadlift = user[0].Results_ID.Deadlift,
                    //    Run60 = user[0].Results_ID.Run60,
                    //    Jump = user[0].Results_ID.Jump
                    //}
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
