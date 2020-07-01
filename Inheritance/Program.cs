using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal- DONE
            // give this class 4 members that all Animals have in common - DONE


            // Create a class Bird - Done
            // give this class 4 members that are specific to Bird - DONe
            // Set this class to inherit from your Animal Class- DONE 

            // Create a class Reptile- Done
            // give this class 4 members that are specific to Reptile- DONE
            // Set this class to inherit from your Animal Class- DONE 




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var baldeagle = new Bird();

            baldeagle.HasTalons = true;
            baldeagle.LaysEggs = true;
            baldeagle.DoesFly = true;
            baldeagle.WarmBlooded = "Yes";
            baldeagle.NumberOfLegs = 2;
            baldeagle.Color = "Brown";

            Console.WriteLine($"The Bald Eagle has {baldeagle.NumberOfLegs} legs and has a {baldeagle.Color} hue.");
            Console.WriteLine($"Does the bird have talons?  {baldeagle.HasTalons}");
            Console.WriteLine($"Does the bird fly?  {baldeagle.DoesFly}");
            Console.WriteLine($"Does the bird lay eggs?  {baldeagle.LaysEggs}");

            Console.WriteLine("");

            var komododragon = new Reptile();

            komododragon.HasTail = true;
            komododragon.HasTeeth = true;
            komododragon.NumberOfLegs = 4;
            komododragon.LandAnimal = "Yes";
            komododragon.WarmBlooded = "No";

            Console.WriteLine($"The Komodo Dragon has a {komododragon.NumberOfLegs} legs.");
            Console.WriteLine($"Does the Komodo Dragon have teeth?  {komododragon.HasTeeth}");
            Console.WriteLine($"Does is the Komodo Dragon Warm Blooded ?  {komododragon.WarmBlooded}");
            Console.WriteLine($"Does the have a tail?  {komododragon.HasTail}");


        }
    }
}
