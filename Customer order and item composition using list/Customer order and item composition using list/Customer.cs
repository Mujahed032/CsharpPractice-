using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Customer_order_and_item_composition_using_list
{
    internal class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
       

        

        public List<Order> orders { get; set; }

        public Address HomeAddress { get; set; }

        public int AddressId { get; set; }

        public int OrderId { get; set; }
        public Customer()
        {

        }
        public Customer(string FirstNAme, string LastName)
        {
            this.FirstName = FirstNAme;
            this.LastName = LastName;
           
           
            
            orders = new List<Order>();
          
        }
        public void Displaycustomer()
        {
            Console.WriteLine($"The Customer {FirstName} {LastName} order the following products.");
            foreach (Order xyzBook in orders)
            {
                Console.WriteLine(xyzBook.ToString());
            }
        }



        public void Describe()
        {
            Console.WriteLine($"Customer FirstName is {FirstName}");
            Console.WriteLine($"Customer LastName is {LastName}");
            Console.WriteLine($"Customer Id is {Id}");
            
           
          
        }

    }

   
}
