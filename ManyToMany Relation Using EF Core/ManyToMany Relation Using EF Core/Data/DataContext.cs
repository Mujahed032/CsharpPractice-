using ManyToMany_Relation_Using_EF_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ManyToMany_Relation_Using_EF_Core.Data
{
    public class DataContext:DbContext
    {
     public   DataContext(DbContextOptions<DataContext> options): base(options) 
        {

        }

    public DbSet<Book> books { get; set; }

    public DbSet<Author> authors { get; set; }
    }
}
