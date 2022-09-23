using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool hollowBones { get; set; }
        public bool hasABeak { get; set; }
        public int featherNumber { get; set; }
        public string featherColor { get; set; }
        public string name { get; set; }

        public void PrintBirdFacts()
        {
            Console.WriteLine($"The following are facts for the {name}");
            Console.WriteLine();
            Console.WriteLine($"Has hollow bones? {hollowBones}");
            Console.WriteLine($"Has has a beak? {hasABeak}");
            Console.WriteLine($"Has this many feathers: {featherNumber}");
            Console.WriteLine($"Has this color feather? {featherColor}");
            Console.WriteLine($"Flies? {flies}");
            Console.WriteLine($"Eats meat? {eatsMeat}");
            Console.WriteLine($"Breathes Underwater? {breathesUnderwater}");
            Console.WriteLine($"Has hollow bones? {hollowBones}");
            Console.WriteLine($"Gives birth to live birth? {liveBirth}");
        }

        public Bird()
        {
            ///is there a way to do this so that the birds would all stay in the bird class and then only 
            ///call the print method from the main class? if so, how? *any way OTHER than static?
            ///is there anything wrong with having the method static there?

            //Bird cardinal = new Bird();     
            //cardinal.liveBirth = false;
            //cardinal.flies = true;
            //cardinal.featherNumber = 1234567890;
            //cardinal.eatsMeat = true;
            //cardinal.featherColor = "Red";
            //cardinal.hasABeak = true;
            //cardinal.breathesUnderwater = false;
            //cardinal.hollowBones = true;          
        }

    }
}
