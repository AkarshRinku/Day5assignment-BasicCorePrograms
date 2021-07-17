using System;
using System.Collections.Generic;
using System.Text;

namespace Day5assigment_BasicCorePrograms
{
    class UC_1FlipCoinHeadsAndTails
    {
        public const int HEAD = 0;
        public const int TAIL = 1;

        double percentageOfHead;
        double percentageOfTail;
        int headsCount = 0;
         int tailsCount = 0;
        public void CheckHeadsOrTailsPercentage()
        {
            Console.WriteLine("Enter the number of times coin to be tossed: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int i = 0;
           
            while (i != N)
            {
                Random random = new Random();
                int tossCheck = random.Next(0, 2);
                if (tossCheck == HEAD)
                {
                    headsCount++;
                }
                else
                {
                    tailsCount++;
                }
                i++;
            }

            Console.WriteLine("Total number of Tails occour: " + tailsCount);
            Console.WriteLine("Total number of Heads occour: " + headsCount);

            percentageOfHead = (double)headsCount / N * 100;
            percentageOfTail = (double)tailsCount / N * 100;

            Console.WriteLine("Percentage of Tails : " + percentageOfTail);
            Console.WriteLine("Percentage of Heads : " + percentageOfHead);
        }
    }
}


       