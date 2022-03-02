using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Bob = new Human("Bob"); //actual values get passed through Main section
            Human Phil = new Human("Phil", 10, 50, 40, 100);
            Phil.Attack(Phil);
            Phil.Attack(Phil);
            Phil.Attack(Bob);
            Bob.Attack(Phil);
        }
    }
}
