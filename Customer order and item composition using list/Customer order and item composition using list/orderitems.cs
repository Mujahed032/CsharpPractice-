namespace Customer_order_and_item_composition_using_list
{
    internal class orderitems
    {
        public int Id { get; set; }

        public double Price { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public orderitems(int Id,double Price, string Name,string Description)
        {
            this.Id = Id;
            this.Price = Price;
            this.Name = Name;
            this.Description = Description;
        }

        public void show()
        {
            Console.WriteLine($"orderitem Id is {Id}");
            Console.WriteLine($"orderitem TotalPrice is {Price}");
            Console.WriteLine($"orderitem Name is {Name}");
            Console.WriteLine($"orderitem Description is {Description}");
        }
    }
}