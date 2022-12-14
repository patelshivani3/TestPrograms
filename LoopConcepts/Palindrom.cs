using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConcepts
{
    internal class Palindrom
    {
       
        public static void ReverseWord(string word)
        {
            string reverse = "";
            char[] chars = word.ToCharArray();
            Console.WriteLine("Displaying each character");
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i] + "  ");
            }
            for (int i = 0; i < chars.Length; i++)
            { 
                reverse=chars[i] + reverse;
            }
            Console.WriteLine("\n"+reverse);

            if (word == reverse)
            {
                Console.WriteLine("It's a Palindrome");
            }
            else
            {
                Console.WriteLine("It's not a Palindrome");
            }
             
        }
    }
}
