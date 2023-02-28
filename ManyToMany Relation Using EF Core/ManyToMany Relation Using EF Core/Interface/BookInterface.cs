using ManyToMany_Relation_Using_EF_Core.Models;

namespace ManyToMany_Relation_Using_EF_Core.Interface
{
    public interface BookInterface
    {
        ICollection<Book> GetBook();
    }
}
