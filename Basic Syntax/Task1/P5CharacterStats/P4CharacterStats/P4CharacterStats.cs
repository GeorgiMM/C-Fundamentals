using System;

namespace P4CharacterStats
{
    class P4CharacterStats
    {
        static void Main(string[] args)
        {
            string name, healthBar, energyBar;
            int currentHealth, maximumHealth, currentEnergy, maximumEnergy, emptyHealth, emptyEnergy;

            name = Console.ReadLine();
            currentHealth = int.Parse(Console.ReadLine());
            maximumHealth = int.Parse(Console.ReadLine());
            currentEnergy = int.Parse(Console.ReadLine());
            maximumEnergy = int.Parse(Console.ReadLine());

            emptyHealth = maximumHealth - currentHealth;
            emptyEnergy = maximumEnergy - currentEnergy;

            healthBar = "|" + new string('|', currentHealth) + new string('.', emptyHealth) + "|";
            energyBar = "|" + new string('|', currentEnergy) + new string('.', emptyEnergy) + "|";
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {healthBar}");
            Console.WriteLine($"Energy: {energyBar}");
            
        }
    }
}
