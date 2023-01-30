namespace Customer_order_and_item_composition_using_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            order Table = new order(1, DateTime.Now,800);
            order bedsheet = new order(2, DateTime.Now, 500);
            Table.method();


            Customer khizar = new Customer("khizar", "Ali", 11);
            khizar.orders.Add(Table);
            khizar.Describe();

           Address customeraddress = new Address(22,92345,"seventombs","hyderbad","telengana",500008,"india");
            customeraddress.CustAddress();

            orderitems orderitem = new orderitems(33,1300,"table and bedsheet","no of item is two");
            orderitem.show();
        }

    }
}