using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConcepts
{
    internal class ReverseProgram
    {
        public static void ReverseNumber()
        {
            int remainder = 0, reverse = 0;

            Console.WriteLine("Please enter the Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            while ( num != 0)
            {
                remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num = num / 10;
                //Console.WriteLine("Rmainder:{0} Number:{1} Reverse:{2}", remainder, num, reverse);
            }
            Console.WriteLine("Reverse number is : " + reverse);
                
        }
    }
}
