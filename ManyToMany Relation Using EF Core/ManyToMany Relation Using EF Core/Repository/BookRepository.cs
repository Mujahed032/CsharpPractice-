using ManyToMany_Relation_Using_EF_Core.Data;
using ManyToMany_Relation_Using_EF_Core.Interface;
using ManyToMany_Relation_Using_EF_Core.Models;

namespace ManyToMany_Relation_Using_EF_Core.Repository
{
    public class BookRepository : BookInterface
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Book> GetBook()
        {
            return _context.books.OrderBy(x => x.Id).ToList();
        }

       
    }
}
