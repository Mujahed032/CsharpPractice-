namespace Inheitance_for_Author_class
{
    internal class Book

    {
        public string Name { get; set; }
        public int Id { get; set; }

        public  double Price { get; set; }
        public   DateTime PublishedDate { get; set; }
        public Book(string name, int id, double price,DateTime Republishyear)
        {
            this.Name = name;
            this.Id = id;
            this.Price = price;
            this.PublishedDate = Republishyear;
        }


        public void Display()
        {
            Console.WriteLine($"Book name is {Name}");
            Console.WriteLine($"Book id is {Id}");
            Console.WriteLine($"Book price is {Price}");
            Console.WriteLine($"Book RepublishYear is {PublishedDate}");
        }

        public override string ToString()
        {
           return $"Book name is {Name}. Book Id is {Id}. Book price is {Price}. Book PublishedDate is {PublishedDate}";
        }

    }
}