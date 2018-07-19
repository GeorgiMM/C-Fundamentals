using System;

namespace P02MultiplicationTable1
{
    class P02MultiplicationTable1
    {
        static void Main(string[] args)
        {
            int number;
            int result = 0;

            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                result = number * i;
                Console.WriteLine($"{number} X {i} = {result}");
            }
        }
    }
}
