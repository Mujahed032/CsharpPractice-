using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_of_Personclass
{
    internal abstract class Person
    {
      public string Name { get; set; }

      public int id { get; set; }

      public bool salaried { get; set; }

        public virtual void DescribeMe()
    }
}
