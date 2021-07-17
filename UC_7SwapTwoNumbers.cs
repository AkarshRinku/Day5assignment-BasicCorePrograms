using System;
using System.Collections.Generic;
using System.Text;

namespace Day5assigment_BasicCorePrograms
{
    class UC_7SwapTwoNumbers
    {
        public int Number1;
        public int Number2;
        public int temp = 0;
        public void Swap2Number()
        {

            Console.WriteLine("\nInput the First Number : "); 
            Number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput the Second Number : ");
            Number2 = Convert.ToInt32(Console.ReadLine());

            temp = Number1;
            
            Number1 = Number2;
            Number2 = temp; 

            Console.WriteLine("\nAfter Swapping : "); 
            Console.WriteLine("\nFirst Number : " + Number1); 
            Console.WriteLine("\nSecond Number : " + Number2);
            Console.Read();
        }
    }
}
