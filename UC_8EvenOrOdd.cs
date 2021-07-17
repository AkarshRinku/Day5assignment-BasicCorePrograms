using System;
using System.Collections.Generic;
using System.Text;

namespace Day5assigment_BasicCorePrograms
{
    class UC_8EvenOrOdd
    {
        public int Number;
        public int Remainder;
        public void CheckEvenOrdd()
        {

            Console.Write("Enter Number to Check whether Number is Even or Odd :\n");
            
            Number = Convert.ToInt32(Console.ReadLine());
            Remainder = Number % 2;

            if (Remainder == 0)
                Console.WriteLine("{0} is an Even Number.", Number);
            else
                Console.WriteLine("{0} is an Odd Number.", Number);
        }
    }
}
