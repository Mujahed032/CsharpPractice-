using Newtonsoft.Json;

namespace Customer_order_and_item_composition_using_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new ShopContext();
            context.Database.EnsureCreated();




            Product Table = new Product( 1400, "IKEA Table", "Brown Dining Table");
            Product Bedsheet = new Product( 250, "IKEA Bedsheet", "Queen Size");
            Product Pen = new Product(50, "Montex", "Blue");
            Table.show();

            

            Order order1 = new Order( DateTime.Now);
            order1.productitem.Add(Table);
            order1.productitem.Add(Bedsheet);
            order1.productitem.Add(Pen);
            double order1TotalPrice = order1.GetTotalPrice();


            Customer khizar = new Customer("khizar", "Ali");
            khizar.orders.Add(order1);


            

            khizar.Displaycustomer();
          


           Address customeraddress = new Address(92345,"seventombs","hyderbad","telengana",500008,"india");

            khizar.HomeAddress = customeraddress;

            context.Customers.Add(khizar);
            context.SaveChanges();
            

            List<Customer> customer = new List<Customer>() { khizar };
            File.WriteAllText("C:\\Users\\hp\\OneDrive\\Desktop\\khizar.json", JsonConvert.SerializeObject(customer));

            string Filecontent = File.ReadAllText("C:\\Users\\hp\\OneDrive\\Desktop\\khizar.jSon");

            var customerread = JsonConvert.DeserializeObject<List<Customer>>(Filecontent);
        }

    }
}