using System;
using System.Collections.Generic;
using System.Text;

namespace Day5assigment_BasicCorePrograms
{
    class UC_3PowerOfTwo
    {
        public int num = 0;
        public void CalculatePowerOf2()
        {

            Console.WriteLine("Enter a number:");

            int num = Convert.ToInt32(Console.ReadLine());

            int result = num * 2; 

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

    

