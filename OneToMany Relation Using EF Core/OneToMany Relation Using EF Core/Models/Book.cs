namespace OneToMany_Relation_Using_EF_Core.Models
{
    public class Book
    {

        public int ID { get; set; }

        public String Title { get; set; }

        

        public Author   Author { get; set; }
    }
}
