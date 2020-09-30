using System;
using System.Runtime.InteropServices;

namespace Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius:");

            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The area of a circle of radius "+ radius +" is: "+ area);

            double circumference = 2 * Math.PI * radius;
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + circumference);

            double diameter = 2 * radius;
            Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + diameter);

            Console.WriteLine("Input miles per gallon of vehicle:");
            double mpg = double.Parse(Console.ReadLine());
            double gallons = circumference / mpg;
            Console.WriteLine("It will take " + gallons + " gallons of gas to make it around the circle with a circumference of " + circumference + " miles.");
        }
    }
}
