using System.Diagnostics;
using System.Xml.Linq;

namespace Customer_order_and_item_composition_using_list
{
    internal class order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

       

        public List<Product> productitem { get; set; }

        public double TotalPrice { get; set; }

        

        public order(int ID, DateTime OrderDate,  double TotalPrice)
        {
            this.Id=ID;
            this.OrderDate=OrderDate;
          
            this.TotalPrice=TotalPrice;
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