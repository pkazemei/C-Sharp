using System;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // randomArray();
            // coinToss();
            // multicoinToss(4);
            names();
        }

        public static void randomArray()
        {
            var rand = new Random();
            int minVal=26;
            int maxVal=0;
            int [] randArray = new int[10];
            for(int i =0; i<randArray.Length; i++)
            {
                randArray[i]= rand.Next(5,26);
                if(minVal>randArray[i])
                {
                    minVal=randArray[i];
                }
                if(maxVal<randArray[i])
                {
                    maxVal=randArray[i];
                }
            }
                Console.WriteLine(minVal);
                Console.WriteLine(maxVal);
                int sum=0;
                foreach(int number in randArray)
                {
                    Console.WriteLine(number);
                    sum+=number;
                }
                Console.WriteLine(sum);
        }

        public static double coinToss(int num)
        {
            Console.WriteLine("Tossing a Coin!");
            var rand = new Random();
            int coinSide = rand.Next(2);
            int headsCount = 0;
            double total = 0.0;
            if(coinSide>0)
            {
                Console.WriteLine("Tails");
            }
            else
            {
                Console.WriteLine("Heads");
                headsCount+=1;
            }
            total = (double)headsCount/num;
            Console.WriteLine($"Win / Loss ratio for heads: {total}");
            return total;
        }

        public static void multicoinToss(int num)
        {
            
            for (int i = 0; i < num; i++)
            {
                coinToss(num);
            }

        }
        public static void names()
        {
            string[] namesArr = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            var rand = new Random();

            for (var i =0; i<namesArr.Length; i++){
                int shuffle = rand.Next(namesArr.Length);
                Console.WriteLine(namesArr[shuffle]);
                }
        }
    }
}