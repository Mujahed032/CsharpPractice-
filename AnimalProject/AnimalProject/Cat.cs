using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    internal class Cat : Animal
    {
       public Cat(string Name,  bool canFly): base(Name, canFly)
        {
           
        }
        public override string MakesSound()
        {
            return "Meow";
        }

        internal override int GetInsurance()
        {
            return 100;
        }
    }
}
