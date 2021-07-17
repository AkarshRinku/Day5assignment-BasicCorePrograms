using System;
using System.Collections.Generic;
using System.Text;

namespace Day5assigment_BasicCorePrograms
{
    class UC_6QuotientAndRemainder
    {
        public void Division()
        {
            Console.WriteLine("Enter the Dividend : ");
            int Dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Divisor : ");
            int Divisor = Convert.ToInt32(Console.ReadLine());


            int quotient = Dividend / Divisor;
            int remainder = Dividend % Divisor;

            Console.WriteLine("Dividend: " + Dividend + " Divisor: " + Divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
