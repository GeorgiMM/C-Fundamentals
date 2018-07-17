using System;

namespace P3KilometersToMiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometers, miles;

            kilometers = double.Parse(Console.ReadLine());

            miles = kilometers * 1.60934;

            Console.WriteLine($"{miles:f2}");
        }
    }
}
