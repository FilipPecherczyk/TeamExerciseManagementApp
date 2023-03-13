using Microsoft.Data.SqlClient;
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
        public static bool CanUserBeLogged(string userLogin, string userPassword)
        {
            SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=TeamDataBase");

            String querry = $"SELECT * FROM Users WHERE Login = '{userLogin}' AND Password = '{userPassword}'";
            SqlDataAdapter adapter = new SqlDataAdapter(querry,conn);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);


            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
