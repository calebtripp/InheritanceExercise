using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Inheritance;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {           
            var cardinal = new Bird();
            cardinal.name = "Cardinal!";
            cardinal.hollowBones = true;
            cardinal.featherNumber = 987654321;
            cardinal.hasABeak = true;
            cardinal.featherColor = "Red";
            cardinal.liveBirth = false;
            cardinal.flies = true;
            cardinal.breathesUnderwater = false;
            cardinal.eatsMeat = true;                   
            cardinal.PrintBirdFacts();

            Console.WriteLine();
            Console.WriteLine();
           
            var alligator = new Reptile();
            alligator.name = "Alligator!";
            alligator.performsDeathroll = true;
            alligator.livesUnderwater = true;
            alligator.bellyColor = "Whitish Yellow";
            alligator.teethNumber = 80;
            alligator.liveBirth = false;
            alligator.flies = false;
            alligator.breathesUnderwater = false;
            alligator.eatsMeat = true;
            alligator.PrintGatorFacts();            
        }
    }
}
