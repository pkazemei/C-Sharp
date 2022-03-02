using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main( string[] args )
        {
            print1To255();
            notDivisByBoth();
            fizzBuzz();
        }

        public static void print1To255()
        {
            for(int i=1;i<=255;i++)
            {
            Console.WriteLine(i);
            }
        }

        public static void notDivisByBoth()
        {
            for(int i=1;i<=100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    continue;
                }
                else if(i%3==0 || i%5==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        public static void fizzBuzz()
        {
            for(int i=1;i<=100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("Buzz");
                }
                Console.WriteLine(i);
            }
        }
    }
}