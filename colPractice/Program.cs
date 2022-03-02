using System;
using System.Collections.Generic;

namespace colPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numArray = new int[10]{0,1,2,3,4,5,6,7,8,9};
            // Console.WriteLine(numArray);
            // string[] strArray = new string[4]{"Tim","Martin", "Nikki", "Sara"};
            // Console.WriteLine(strArray);

            bool value = true;
            bool[] boolArray = new bool[10];
            {
            for (int i = 0; i <= boolArray.Length; i++){
                if(i%2==0){
                    value= true;
                    Console.WriteLine($"Value is {value}");
                }
                else{
                    value = false;
                    Console.WriteLine($"Value is {value}");
                }
            }
            }
        }
    }
}

// Three Basic Arrays

//     Create an array to hold integer values 0 through 9
//     Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
//     Create an array of length 10 that alternates between true and false values, starting with true

