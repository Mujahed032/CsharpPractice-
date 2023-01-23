using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    internal class Horse : Animal
    {
        public Horse(string Name, bool canFly) : base(Name, canFly)
        {

        }
        
        public override string MakesSound()
        {
            return "Neigh";
        }

        internal override int GetInsurance()
        {
            return 1000;  
        }

        public override void DescribeMe()
        {
            Console.WriteLine($"I am a {Name} I cannot fly. The sound I make is : {MakesSound()}");
            Console.WriteLine("You need to take extra care of this animal. This is very expensive.");
        }
    }
}
