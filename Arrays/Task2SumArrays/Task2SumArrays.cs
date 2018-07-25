using System;
using System.Linq;

namespace Task2SumArrays
{
    class Task2SumArrays
    {
        static void Main(string[] args)
        {
            int lenghtArr;
            string input = Console.ReadLine();
            int[] nums1 = input.Split()
                .Select(int.Parse)
                .ToArray();
            input = Console.ReadLine();
            int[] nums2 = input.Split()
                .Select(int.Parse)
                .ToArray();

            lenghtArr = CountLenghtArr(nums1, nums2);

            if (nums1 != nums2)
            {
                if (IsArr1Longer(nums1, nums2))
                {
                    nums2 = ToEqualArray(lenghtArr, nums2);
                }
                else 
                {
                    nums1 = ToEqualArray(lenghtArr, nums1);
                }
            }
            int[] result = new int[lenghtArr];
            result = SumArrays(nums1, nums2);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        static int[] SumArrays(int[] arr1, int[] arr2)
        {
            int[] sumedArr = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                sumedArr[i] = arr1[i] + arr2[i];
            }
            return sumedArr;
        }

        static int CountLenghtArr(int[] arr1, int[] arr2)
        {
            int count;
            if (arr1.Length > arr2.Length)
            {
                count = arr1.Length;
            }
            else
            {
                count = arr2.Length;
            }
            return count;
        }

        static bool IsArr1Longer(int[] arr1, int[] arr2)
        {
            bool flag;
            if (arr1.Length > arr2.Length)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        static int[] ToEqualArray(int lenghtArr, int[] source)
        {
            int[] resultArr = new int[lenghtArr];
            int counter = 0;
            int innerCounter = 0;
            while (counter < lenghtArr)
            {
                for (int i = 0; i < source.Length; i++)
                {
                    resultArr[innerCounter] = source[i];
                    innerCounter++;
                    counter++;
                    if (counter == lenghtArr)
                    {
                        break;
                    }
                }
            }
            return resultArr;
        }
    }
}
