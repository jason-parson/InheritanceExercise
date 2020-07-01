using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        {
        
        }
        public bool HasScales { get; set; }
        public string LandAnimal { get; set; }
        public bool WarmClimate { get; set; }
        public bool HasTeeth{ get; set; }


    }
}
