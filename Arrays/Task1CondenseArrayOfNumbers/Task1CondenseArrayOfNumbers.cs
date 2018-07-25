using System;
using System.Linq;

namespace Task1CondenseArrayOfNumbers
{
    class Task1CondenseArrayOfNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] nums = input.Split()
                .Select(int.Parse)
                .ToArray();
            while (nums.Length > 1)
            {
                nums = CondenseArray(nums);
            }
            Console.WriteLine(nums[0]);

        }

        static int[] CondenseArray(int[] nums)
        {
            int[] condencedArr = new int[nums.Length - 1];
            for (int i = 0; i < nums.Length-1; i++)
            {
                nums[i] += nums[i + 1];
            }
            for (int i = 0; i < condencedArr.Length; i++)
            {
                condencedArr[i] = nums[i];
            }

            return condencedArr;
        }
    }
}
