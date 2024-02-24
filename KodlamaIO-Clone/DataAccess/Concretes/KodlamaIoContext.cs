using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class KodlamaIoContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\nil;Database=KodlamaIoCloneDb;Trusted_Connection=true");
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<CourseProgramme> CourseProgrammes { get; set; }
}