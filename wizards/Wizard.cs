using System;

namespace wizards
{
    public class Wizard : Human
    {
    public Wizard(string name) : base(name) //get name and change name
    {
        Name=name;
        Health=50;
        Intelligence=25;
    }

    public override int Attack(Human target)
    {
        int dmg=this.Intelligence*5;
        target.Health-=dmg;
        this.Health+=dmg; //gain health based off damage dealt
        Console.WriteLine(target.Health);
        return target.Health;
    }

    public int Heal(Human target) //heal target human 
    {
        target.Health+=this.Intelligence*10;
        Console.WriteLine(target.Health);
        return target.Health;
    }
    }
}