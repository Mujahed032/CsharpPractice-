namespace Inheitance_for_Author_class
{
    internal class Book

    {
        public string name { get; set; }
        public int id { get; set; }

        public  double price { get; set; }
        public   int Republishyear { get; set; }
        public Book(string name, int id, double price,int Republishyear)
        {
            this.name = name;
            this.id = id;
            this.price = price;
            this.Republishyear = Republishyear;
        }
        public void Display()
        {
            Console.WriteLine($"Book name is {name}");
            Console.WriteLine($"Book id is {id}");
            Console.WriteLine($"Book price is {price}");
            Console.WriteLine($"Book RepublishYear is {Republishyear}");
        }

    }
}