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

        public static bool IsInDataBaseAlreadyThatUser(string login)
        {
            var dbContext = new Context();
            var user = dbContext.Users.Where(u => u.Login == login).ToList();

            if (user.Count > 0)
            {
                return true;
            }

            return false;
        }
         
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

        
    }
}
