using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Reverse Number\n2.Palindrome\n3.Array Concept\n\nChoose the program from above option");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ReverseProgram.ReverseNumber();
                    break;

                case 2:
                    Console.WriteLine("Please enter the word to make reverse: ");
                    Palindrom.ReverseWord(Console.ReadLine());
                    break;

                case 3:
                    ArrayConcepts.TestArray();
                    break;

                default:
                    Console.WriteLine("Please choose the program from given option");
                    break;

            }
            Console.ReadLine();
        }
    }
}
