using System;

namespace P4BeverageLabels
{
    class P4BeverageLabels
    {
        static void Main(string[] args)
        {
            string productName;
            int volume, energyContent;
            double sugarContent, totalSugar, totalcCalories;

            productName = Console.ReadLine();
            volume = int.Parse(Console.ReadLine());
            energyContent = int.Parse(Console.ReadLine());
            sugarContent = double.Parse(Console.ReadLine());

            totalcCalories = volume * energyContent / 100.0;
            totalSugar = volume * sugarContent / 100.0;


            Console.WriteLine($"{volume}ml {productName}:");
            Console.WriteLine($"{totalcCalories:f0}kcal, {totalSugar:f0}g sugars");
        }
    }
}
