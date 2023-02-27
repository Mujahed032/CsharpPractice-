using Microsoft.EntityFrameworkCore;
using OneToMany_Relation_Using_EF_Core.Models;

namespace OneToMany_Relation_Using_EF_Core.Data
{
    public class DataContext:DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    public DbSet<Book> books { get; set; }

    public DbSet<Author> authors { get; set; }
    }
}
