using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public bool CanFly { get; set; }

        public abstract string MakesSound();

        public virtual void DescribeMe()
        {
            if (CanFly)
                Console.WriteLine($"I am a {Name}. I can fly. The sound I make is : {MakesSound()}");
            else
                Console.WriteLine($"I am a {Name} I cannot fly. The sound I make is : {MakesSound()}");
        }
    }
}
