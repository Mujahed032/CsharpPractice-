using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_testing_file
{
    internal class Student:Person
    {
        private string v;

        public Student(string name, int id, string subject) : base(name, id,subject)
        {
            
            this.id = id;
            this.Name = name;
            this.subject= subject;


        }

        

        public override void DescribeMe()
        {
            Console.WriteLine("student name is " + Name + " and he is studying "+ subject);
            Console.WriteLine("student id is " + id);
         
        }

    }
}
