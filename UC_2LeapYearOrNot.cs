using System;
using System.Collections.Generic;
using System.Text;

namespace Day5assigment_BasicCorePrograms
{
    class UC_2LeapYearOrNot
    {
        public void CheckLeapOrNot()
        {
            Console.WriteLine("Enter to Year of 4 digits to Check if it is Leap Year or Not: ");

           
            int year = Convert.ToInt32(Console.ReadLine()); 

            if (( year % 4 == 0 && (year % 10 != 0)))

                Console.WriteLine(year + " is a Leap Year");
            else
                Console.WriteLine(year + " is not a Leap Year");
           
        }
    }
}

