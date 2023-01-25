using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_testing_file
{
    internal class employee : Person
    {
        double salary;
        string designation;
        public employee(string name, int id, double salary, string designation) : base(name, id)
        { 
            this.salary = salary;
            this.id = id;
            this.Name = name;
            this.designation = designation;


        }

        public override void DescribeMe()
        {
            Console.WriteLine("employee name is: "+Name+" And his desgination is "+designation);
            Console.WriteLine("employee id is: "+id);
            Console.WriteLine("employee salary is: " + salary);
        }
        
    }
   

}
