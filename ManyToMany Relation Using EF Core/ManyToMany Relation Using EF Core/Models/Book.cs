namespace ManyToMany_Relation_Using_EF_Core.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<Author> Author { get; set; }
    }
}
