using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common
            var myBird = new Bird();
            myBird.WingColor = "white";
            myBird.canFly = true;
            myBird.DoMove = false;
            myBird.Blength = 3.4;
            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            var myReptile = new Reptile();
            myReptile.hasTail = true;
            myReptile.isLarge = false;
            myReptile.isFastMoving = true;
            myReptile.enviroLiving = "moderate climate";
            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            var myAnimals = new Animal[] { myBird, myReptile };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.isAlive}");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"Eats:{animal.food}");
                Console.WriteLine($"It has:{animal.NumberofLegs}");
            }


        }
    }

    }
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        
  