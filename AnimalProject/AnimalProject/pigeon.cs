using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    internal class pigeon : Animal
    {
        public pigeon(string Name, bool canFly) : base(Name, canFly)
            {
                
            }
            public override string MakesSound()
            {
                return "coo";
            }

        internal override int GetInsurance()
        {
            return 200;
        }
    }
}
