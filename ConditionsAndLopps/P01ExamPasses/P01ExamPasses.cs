using System;

namespace P01ExamPasses
{
    class P01ExamPasses
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            int stepNum =1;

            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++, stepNum+=2)
            {
                Console.WriteLine(stepNum);
                sum += stepNum;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
