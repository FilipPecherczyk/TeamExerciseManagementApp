using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamExerciseManagementApp.Models.UserEntities
{
    public class Context : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<PlayerResults> PlayerResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TeamDataBase");
        }
    }
}
