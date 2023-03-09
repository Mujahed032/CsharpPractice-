using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningClassRelationsUsingConsole
{
    internal class DataContext:DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
                
        }

    public DbSet<Student> students { get; set; }

    public DbSet<Course> courses { get; set; }

    public DbSet<Teacher> teachers { get; set; }    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-MFK0N4P;Initial Catalog=StudentCourse;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
