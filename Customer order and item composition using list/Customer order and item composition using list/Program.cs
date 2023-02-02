using Newtonsoft.Json;

namespace Customer_order_and_item_composition_using_list
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Product Table = new Product(1, 1400, "IKEA Table", "Brown Dining Table");
            Product Bedsheet = new Product(2, 250, "IKEA Bedsheet", "Queen Size");
            Product Pen = new Product(3, 50, "Montex", "Blue");
            Table.show();

            

            order order1 = new order(11, DateTime.Now);
            order1.productitem.Add(Table);
            order1.productitem.Add(Bedsheet);
            order1.productitem.Add(Pen);
            order1.method();


            Customer khizar = new Customer("khizar", "Ali", 111);
            khizar.orders.Add(order1);
            

            

            khizar.Displaycustomer();
          


           Address customeraddress = new Address(22,92345,"seventombs","hyderbad","telengana",500008,"india");
            customeraddress.CustAddress();

            Console.WriteLine(Table.ToString());

            List<Customer> customer = new List<Customer>() { khizar };
            File.WriteAllText("C:\\Users\\hp\\OneDrive\\Desktop\\khizar.json", JsonConvert.SerializeObject(customer));

            string Filecontent = File.ReadAllText("C:\\Users\\hp\\OneDrive\\Desktop\\khizar.jSon");

            var customerread = JsonConvert.DeserializeObject<List<Customer>>(Filecontent);
        }

    }
}