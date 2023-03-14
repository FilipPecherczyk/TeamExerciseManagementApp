using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamExerciseManagementApp.Models.UserEntities;

namespace TeamExerciseManagementApp.Models.DataBaseOperations
{
    public static class ListOfUsers
    {
        public static List<User> PlayersList { get; set; }

        public static void CreateListOfPlayers()
        {
            var dbContext = new Context();
            var players = dbContext.Users.Where(u => u.UserCategory == Enums.UserCategories.Player).ToList();
            PlayersList = players;
        }
    }
}
