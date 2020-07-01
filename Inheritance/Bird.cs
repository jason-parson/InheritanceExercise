using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() 
        { 
                 
        }

        public bool HasFeathers { get; set; }
        public bool DoesFly { get; set; }
        public bool HasTalons { get; set; }
        public bool LaysEggs { get; set; }
        public string Color { get; set; }

        
    } 
    


}
