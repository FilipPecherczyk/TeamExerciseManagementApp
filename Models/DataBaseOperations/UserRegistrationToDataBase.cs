using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamExerciseManagementApp.Models.UserEntities;

namespace TeamExerciseManagementApp.Models.DataBaseOperations
{
    public static class UserRegistrationToDataBase
    {
        public static void AddUser()
        {
            var context = new Context();
            var user = new User()
            {
                FirstName = "Filip",
                LastName = "Kowalski",
                Birthday = DateTime.Now,
                UserCategory = Enums.UserCategories.Player,
                Login = "Filip",
                Password = "haslo123",
                Results_ID = new PlayerResults
                {
                    Weight = 82,
                    Height = 183,
                }
            };

            context.Add(user);
            context.SaveChanges();
        }
    }
}
