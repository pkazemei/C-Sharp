using System;

namespace wizards
{
    public class Ninja : Human
    {
    public Ninja(string name) : base(name) //get name and change name
    {
        Name=name;
        Dexterity=175;
    }

    public override int Attack(Human target)
    {
        int dmg=this.Dexterity*5;
        target.Health-=dmg;
        var rand = new Random();
        var chance = rand.Next(1, 6);
        if (chance == 5) //20% chance
        {
            dmg=10;
            target.Health-=dmg;
        }
            Console.WriteLine(target.Health);
        return target.Health;
    }

    public int Steal(Human target) //heal target human 
    {
        target.Health-=5; //reduce target health
        this.Health+=5; //add health
        Console.WriteLine(target.Health);
        return target.Health;
    }
    }
}