using System;

namespace P1CreditCardNumber
{
    class P1CreditCardNumber
    {
        static void Main(string[] args)
        {
            int[] number= new int[4];

            for (int i = 0; i < 4; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{number[i]:d4} ");
            }
        }
    }
}
