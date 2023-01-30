namespace Customer_order_and_item_composition_using_list
{
    internal class order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

       

        public List<orderitems> orderitems { get; set; }

        public double TotalPrice { get; set; }

        

        public order(int ID, DateTime OrderDate,  double TotalPrice)
        {
            this.Id=ID;
            this.OrderDate=OrderDate;
          
            this.TotalPrice=TotalPrice;
            orderitems = new List<orderitems>();
        }
        public void method()
        {
            Console.WriteLine($"order id is {Id}");
            Console.WriteLine($"order Date is {OrderDate}");
           
            Console.WriteLine($"order Price is {TotalPrice}");
        }
      
    }  
}