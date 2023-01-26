using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_testing_file
{
    internal class Student:Person
    {
        string subject;

        public Student(string name, int id, string subject) : base(name, id)
        {
                    
            this.subject= subject;


        }

        

        public override void DescribeMe()
        {
            Console.WriteLine("student name is " + FirstName + " and he is studying "+ subject);
            Console.WriteLine("student id is " + id);
         
        }

    }
}
