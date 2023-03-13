using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamExerciseManagementApp.Enums;

namespace TeamExerciseManagementApp.Models.UserEntities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public UserCategories UserCategory { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }

        public PlayerResults Results_ID { get; set; }
    }
}
