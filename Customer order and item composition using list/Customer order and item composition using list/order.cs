using System.Diagnostics;
using System.Xml.Linq;

namespace Customer_order_and_item_composition_using_list
{
    internal class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }



        public List<Product> productitem { get; set; }
        
        public double TotalPrice {get; set; }

        public int CustomerId { get; set; }
        public double GetTotalPrice()
        {
            double returnPrice = 0;
            foreach (var product in productitem)
            {
                returnPrice = returnPrice + product.Price;
            }
            TotalPrice = returnPrice;
            return returnPrice;
        }

        public Order()
        {

        }
        public Order( DateTime OrderDate)
        {
            
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