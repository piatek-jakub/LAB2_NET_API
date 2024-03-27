using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ExercisesForms")]
namespace LAB2_NET_Simple
{
    internal class ExercisesDB : DbContext
    {
        public DbSet<Exercise> exercises { get; set; }
        public ExercisesDB()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"DataSource=Exercises.db");
        }

        
    }
}
