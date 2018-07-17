using System;

namespace P2RectangleArea
{
    class P2RectangleArea
    {
        static void Main(string[] args)
        {
            double width, height, sum;

            width = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());

            sum = width * height;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
