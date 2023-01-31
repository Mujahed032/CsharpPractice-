using Newtonsoft.Json;

namespace Customer_order_and_item_composition_using_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            order Table = new order(1, DateTime.Now);
            order bedsheet = new order(2, DateTime.Now);
            order pen = new order (3, DateTime.Now);
            Table.method();

            //Product Productitem = new Product(33, 1300, "table and bedsheet", "no of item is two");
            //Productitem.show();


            Customer khizar = new Customer("khizar", "Ali", 11);
            khizar.orders.Add(Table);
            

            Customer azhar = new Customer("azhar", "khan", 22);
            azhar.orders.Add(pen);

            khizar.Displaycustomer();
            azhar.Displaycustomer();


           Address customeraddress = new Address(22,92345,"seventombs","hyderbad","telengana",500008,"india");
            customeraddress.CustAddress();

            Console.WriteLine(Table.ToString());

            List<Customer> customer = new List<Customer>() { khizar, azhar };
            File.WriteAllText("C:\\Users\\hp\\OneDrive\\Desktop\\khizar.json", JsonConvert.SerializeObject(customer));

            string Filecontent = File.ReadAllText("C:\\Users\\hp\\OneDrive\\Desktop\\khizar.jSon");

            var customerread = JsonConvert.DeserializeObject<List<Customer>>(Filecontent);
        }

    }
}