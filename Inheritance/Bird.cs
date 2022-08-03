using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {

        public Bird()
        {
            food = "grains";
            NumberofLegs = 2;
            Age = 3;
            isAlive = true;
        } 
        public string WingColor { get; set; }
        public bool canFly { get; set; }

        public bool DoMove { get; set; }
        
        public double Blength { get; set; }

    }
}