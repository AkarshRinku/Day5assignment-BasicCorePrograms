using System;
using System.Collections.Generic;
using System.Text;
namespace Day5assigment_BasicCorePrograms
{
    class UC_9VowelOrNot
    {
        public Char Ch;

        public void CheckGivenVowel()
        {
            Console.Write("Enter a is a vowel or not:\n");

            Ch = Convert.ToChar(Console.ReadLine());
            if (Ch == 'A' | Ch == 'E' | Ch == 'I' | Ch == 'O' | Ch == 'U' | Ch == 'a' | Ch == 'e' | Ch == 'i' | Ch == 'o' | Ch == 'u')
            { 

            Console.WriteLine(Ch + " is a Vowel");

            }

            else
                {
                    Console.WriteLine(Ch + " is a Consonant");
                }
        }

    }
}
