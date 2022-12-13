using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrograms
{
    internal class Addition
    {
        public void Add()
        { 
            int firstno =0 , secondno = 0 ;
            Console.Write("\nEnter the 1st No : ");
            firstno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd No : ");
            secondno = Convert.ToInt32(Console.ReadLine());
            int sum = firstno + secondno;
            Console.WriteLine("Addition : " +sum);

        }
    } 
    
}
