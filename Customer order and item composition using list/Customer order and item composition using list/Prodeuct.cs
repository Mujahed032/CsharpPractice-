namespace Customer_order_and_item_composition_using_list
{
    public class Product
    {
        public int Id { get; set; }

        public double Price { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public Product(int Id, double Price, string Name, string Description)
        {
            this.Id = Id;
            this.Price = Price;
            this.Name = Name;
            this.Description = Description;
        }

        public void show()
        {
            Console.WriteLine($"Product Id is {Id}");
            Console.WriteLine($"Product TotalPrice is {Price}");
            Console.WriteLine($"Product Name is {Name}");
            Console.WriteLine($"Product Description is {Description}");
        }
    }
}