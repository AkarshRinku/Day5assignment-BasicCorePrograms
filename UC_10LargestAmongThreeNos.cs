using System;
using System.Collections.Generic;
using System.Text;

namespace Day5assigment_BasicCorePrograms
{
    class UC_10LargestAmongThreeNos
    {
        public int Number1;
        public int Number2;
        public int Number3;

        public void checkLargestNumber()
        {
            Console.WriteLine("Enter first number: ");
            Number1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            Number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            Number3 = Convert.ToInt32(Console.ReadLine());

            if (Number1 > Number2 && Number1 > Number3)
            {
                Console.WriteLine(Number1 + " is the largest among three numbers");
            }
            else if (Number2 > Number1 && Number2 > Number3)
            {
                Console.WriteLine(Number2 + " is the largest among three numbers");
            }
            else if (Number3 > Number1 && Number3 > Number2)
            {
                Console.WriteLine(Number3 + " is the largest among three numbers");
            }
            else
            {
                Console.WriteLine("All three numbers are equal");
            }
        }
    }
}

