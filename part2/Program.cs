using System;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the rectangle?");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of the rectangle?");
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            Console.WriteLine("The area of the rectangle is " + area);
        }
    }
}
