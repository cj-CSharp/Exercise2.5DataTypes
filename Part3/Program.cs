using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons of gas were used?");
            double gas = double.Parse(Console.ReadLine());
            double milesPerGallon = miles / gas;
            Console.WriteLine("You averaged " + milesPerGallon + " miles per gallon.");
        }
    }
}
