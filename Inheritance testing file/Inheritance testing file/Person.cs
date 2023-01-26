using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_testing_file
{
    internal abstract class Person
    {
        private string _FirstName;
        public string FirstName 
        {
            get { return _FirstName; } 
            set
            {
                if(string.IsNullOrEmpty(value))
                    
                    throw new ArgumentNullException("First Name cannot be blank.");
               
                else
                _FirstName = value;
            }
        }

        private string _LastName;

        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (string.IsNullOrEmpty(value))

                    throw new ArgumentNullException("Last Name cannot be blank.");

                else
                    _LastName = value;
            }
        }
        public int id { get; set; }


       

        protected Person(string firstName, int id)
        {
            this.FirstName = firstName;
            this.id = id;
         
        }

        

        public virtual void DescribeMe()
        {
            
        }

    }
          

}
