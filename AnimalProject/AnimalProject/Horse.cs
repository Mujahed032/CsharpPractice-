﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    internal class Horse : Animal
    {
        public Horse(string Name, bool canFly)
        {
            this.Name = Name;
            this.CanFly = canFly;
        }
        public override string MakesSound()
        {
            return "Neigh";
        }
    }
}