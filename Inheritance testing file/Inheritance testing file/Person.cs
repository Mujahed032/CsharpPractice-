using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_testing_file
{
    internal abstract class Person
    {
        private string designation;

        public string Name { get; set; }
        public int id { get; set; }
        
        public double salary { get; set; }

        public string desgination { get; set; }
        public string subject { get; set; }

       

        protected Person(string name, int id, double salary, string designation)
        {
            Name = name;
            this.id = id;
            this.salary = salary;
            this.designation = designation;
        }

        protected Person(string name, int id, string subject)
        {
            Name = name;
            this.id = id;
            this.subject = subject;
        }

        public virtual void DescribeMe()
        {
            
        }

    }
          

}
