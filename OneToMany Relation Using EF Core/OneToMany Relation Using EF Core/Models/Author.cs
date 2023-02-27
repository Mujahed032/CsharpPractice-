namespace OneToMany_Relation_Using_EF_Core.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

         

        public ICollection<Book> books { get; set; }


    }
}
