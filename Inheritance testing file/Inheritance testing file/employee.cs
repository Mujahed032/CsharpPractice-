using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_testing_file
{
    internal class employee : Person
    {
        public employee(string name, int id, double salary, string designation) : base(name, id, salary,designation)
        {
            this.salary = salary;
            this.id = id;
            this.Name = name;
            this.desgination = desgination;


        }

        public override void DescribeMe()
        {
            Console.WriteLine("employee name is: "+Name+" And his desgination is "+desgination);
            Console.WriteLine("employee id is: "+id);
            Console.WriteLine("employee salary is: " + salary);
        }
        
    }
   

}
