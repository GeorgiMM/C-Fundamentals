using System;

namespace P03MultiplicatinoTable2
{
    class P03MultiplicatinoTable2
    {
        static void Main(string[] args)
        {
            int number, count;
            int result;

            number = int.Parse(Console.ReadLine());
            count = int.Parse(Console.ReadLine());

            if (count > 10)
            {
                result = number * count;
                Console.WriteLine($"{number} X {count} = {result}");
            } else
            {
                for (int i = count; i <= 10; i++)
                {
                    result = number * i;
                    Console.WriteLine($"{number} X {i} = {result}");
                }
            }
        }
    }
}
