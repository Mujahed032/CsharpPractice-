using System.Diagnostics;
using System.Xml.Linq;

namespace Customer_order_and_item_composition_using_list
{
    internal class order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }



        public List<Product> productitem { get; set; }
        private double _TotalPrice = 0;
        public double TotalPrice {
            get
            {
                return 0;
                //Write a method here to get the total price by adding all the products in this order.
                foreach (var product in productitem);

                
            }
        }

        

        public order(int ID, DateTime OrderDate)
        {
            this.Id=ID;
            this.OrderDate=OrderDate;          
          
            productitem = new List<Product>();
        }
        public void method()
        {
            Console.WriteLine($"order id is {Id}");
            Console.WriteLine($"order Date is {OrderDate}");
           
            Console.WriteLine($"order Price is {TotalPrice}");
        }
        public override string ToString()
        {
            return $"order Id is {Id}. OrderDate is {OrderDate}. order TotalPrice is {TotalPrice}";
        }
    }  
}