using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool performsDeathroll { get; set; }
        public bool livesUnderwater { get; set; }
        public int teethNumber { get; set; }
        public string bellyColor { get; set; }
        public string name { get; set; }

        public void PrintGatorFacts()
        {
            Console.WriteLine($"The following are facts for the {name}");
            Console.WriteLine();
            Console.WriteLine($"Flies? {flies}");
            Console.WriteLine($"Eats meat? {eatsMeat}");
            Console.WriteLine($"Breathes Underwater? {breathesUnderwater}");
            Console.WriteLine($"Gives birth to live birth? {liveBirth}");
            Console.WriteLine($"Has this many teeth {teethNumber}");
            Console.WriteLine($"Performs Deathroll? {performsDeathroll}");
            Console.WriteLine($"Lives Underwater? {livesUnderwater}");
            Console.WriteLine($"Belly Color? {bellyColor}");
        }

        public Reptile()
        {
        }
    }
}

