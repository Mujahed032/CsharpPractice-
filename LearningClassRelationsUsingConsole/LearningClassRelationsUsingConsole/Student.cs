using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningClassRelationsUsingConsole
{
    internal class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Course> courses { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
