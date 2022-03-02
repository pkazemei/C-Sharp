using System;
using System.Collections.Generic;

namespace wizards
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Wizard1 = new Wizard("Marlin");
            Console.WriteLine(Wizard1.Name);
            Samurai Samurai1 = new Samurai("Solid Snake");
            Console.WriteLine(Samurai1.Name);
            Ninja Ninja1 = new Ninja("Ryu Hayabusa");
            Console.WriteLine(Ninja1.Name);

            Console.WriteLine("Starting Health");
            Wizard1.Attack(Samurai1);
            Samurai1.Attack(Ninja1);
            Console.WriteLine("20% Chance for +10 damage");
            Ninja1.Attack(Wizard1);

            Console.WriteLine("Health after Attack");
            Wizard1.Heal(Ninja1);
            Samurai1.Meditate(Samurai1);
            Ninja1.Steal(Wizard1);
        }

    }
}
