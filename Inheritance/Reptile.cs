using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {

        public Reptile()
        {
            food = "inscets";
            NumberofLegs = 4;
            Age = 5;
            isAlive = true;
        }
        public string enviroLiving { get; set; }
        public bool isFastMoving { get; set; }

        public bool hasTail { get; set; }
        public bool isLarge { get; set; }

    }
}