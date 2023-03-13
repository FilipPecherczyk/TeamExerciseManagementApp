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
        public static User UserToRegistration = new User()
        {
            FirstName = "Jan",
            LastName = "Kowalski",
            Birthday = DateTime.Now,
            UserCategory = Enums.UserCategories.Player,
            Login = "Jan",
            Password = "haslo",
            Results_ID = new PlayerResults
            {
                Weight = 82,
                Height = 183,
            }
        };

        /// <summary>
        /// Add user to database
        /// </summary>
        public static void UserRegistration()
        {
            var context = new Context();
            context.Add(UserToRegistration);
            context.SaveChanges();
        }

        //public static void AddUser()
        //{
        //    var context = new Context();
        //    var user = new User()
        //    {
        //        FirstName = "Filip",
        //        LastName = "Kowalski",
        //        Birthday = DateTime.Now,
        //        UserCategory = Enums.UserCategories.Player,
        //        Login = "Filip",
        //        Password = "haslo123",
        //        Results_ID = new PlayerResults
        //        {
        //            Weight = 82,
        //            Height = 183,
        //        }
        //    };

        //    context.Add(user);
        //    context.SaveChanges();
        //}
    }
}
