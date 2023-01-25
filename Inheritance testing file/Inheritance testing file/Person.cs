using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_testing_file
{
    internal abstract class Person
    {
        

        public string Name { get; set; }
        public int id { get; set; }


       

        protected Person(string name, int id)
        {
            this.Name = name;
            this.id = id;
         
        }

        

        public virtual void DescribeMe()
        {
            
        }

    }
          

}
