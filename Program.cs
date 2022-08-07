using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            int bronze = 1;
            int silver = 5;
            int gold = 10;

            Console.WriteLine("Please Enter an amount of cents, I'll break that down into bronze silver and gold coins");
            Console.WriteLine("Bronze = $ .01");
            Console.WriteLine("Silver = $ .05");
            Console.WriteLine("Gold = $ .10");

            int response = Convert.ToInt32(Console.ReadLine());

            int divisibleByGold = response / gold;
            int remainderOfGold = response % gold;
            int divisibleBySilver = remainderOfGold / silver;
            int remainderOfSilver = remainderOfGold % silver;
            int divisibleByBronze = remainderOfSilver / bronze;
        
            Console.WriteLine("Gold = " + divisibleByGold);
            Console.WriteLine("Silver = " + divisibleBySilver); 
            Console.WriteLine("Bronze = " + divisibleByBronze);

        }
    }
}

