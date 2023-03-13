using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TeamExerciseManagementApp.Models.UserEntities
{
    [Table("PlayerResults")]
    public class PlayerResults
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Results_ID { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public int Height { get; set; }
        public int BenchPress { get; set; }
        public int Squats { get; set; }
        public int Deadlift { get; set; }
        public int Run60 { get; set; }
        public int Jump { get; set; }

    }
}
