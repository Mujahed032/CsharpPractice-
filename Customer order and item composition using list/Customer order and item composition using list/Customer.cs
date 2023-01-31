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
       
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int Id { get; set; }
       

        

        public List<order> orders { get; set; }

        public List<Address> Address { get; set; }

        public Customer(string FirstNAme, string LastName, int Id)
        {
            this.FirstName = FirstNAme;
            this.LastName = LastName;
            this.Id = Id;
           
            
            orders = new List<order>();
            Address = new List<Address>();
        }
        public void Displaycustomer()
        {
            Console.WriteLine($"The Customer {FirstName} {LastName} order the following products.");
            foreach (order xyzBook in orders)
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
