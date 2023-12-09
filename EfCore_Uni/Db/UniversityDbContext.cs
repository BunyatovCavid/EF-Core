using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCore_Uni.Db.Entites;
using Microsoft.EntityFrameworkCore;

namespace EfCore_Uni.Db
{
    internal class UniversityDbContext : DbContext
    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WIN-PFGV5N8DK24;Database=University;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One to Many
            modelBuilder.Entity<Course>()
                .HasMany(c => c.StudentsGrade)
                .WithOne(s => s.Course)
                .HasForeignKey(s=>s.CourseId)
                .OnDelete(DeleteBehavior.Cascade);


        }


    }
}
