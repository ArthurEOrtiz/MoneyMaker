using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            double bronze = .01;
            double silver = .05;
            double gold = .10;

            Console.WriteLine("Please Enter an amount of $, I'll break that down into bronze silver and gold coins");
            Console.WriteLine("Bronze = $ .01");
            Console.WriteLine("Silver = $ .05");
            Console.WriteLine("Gold = $ .10");

            double response = Convert.ToDouble(Console.ReadLine());

            //divisible by ten

            double divisibleByGold = Math.Floor(response / gold);
            //double remainderOfGold = response % gold;
            Console.WriteLine(divisibleByGold);
        }
    }
}

