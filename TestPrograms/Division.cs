using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrograms
{
    internal class Division
    {
        public void Div()
        {
            float firstno = 0, secondno = 0;
            Console.Write("\nEnter the 1st No : ");
            firstno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd No : ");
            secondno = Convert.ToInt32(Console.ReadLine());
            float div = firstno / secondno;
            Console.WriteLine("Division : " +div);
        }
    }
}
