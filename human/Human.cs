using System;

namespace human
{
class Human
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
    public int Health {get{return health;}}

    public Human (string n, int str, int intel, int dex, int heal) //constructor
    {
        Name = n;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        health = heal;
    }



    public Human (string n) //overloading constructor
    {
        Name = n;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        health = 100;
    }

    // Build Attack method
    public int Attack(Human target)
    {
        return target.health-=Strength*5; //access target health
    }
}
}