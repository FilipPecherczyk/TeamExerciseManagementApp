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

        public static int LogedUserID { get; set; }

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
                LogedUserID = user[0].User_ID;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
