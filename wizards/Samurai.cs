using System;

namespace wizards
{
    public class Samurai : Human
    {
    public Samurai(string name) : base(name) //get name and change name
    {
        Name=name;
        Health=200;
    }

    public override int Attack(Human target)
    {
        if(target.Health < 50)
        {
            target.Health=0;
        }
        Console.WriteLine(target.Health);
        return target.Health;
    }
    public int Meditate(Samurai target) //heal target human 
    {
        target.Health+=100;
        Console.WriteLine(target.Health);
        return target.Health;
    }
    }
}