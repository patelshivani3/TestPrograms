using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrograms
{
    internal class LocalVariables
    {   
        public LocalVariables() 
        {
            Console.WriteLine("Default Constructor");
        }
        public LocalVariables(int a)
        {
            Console.WriteLine("Parameterized Constructor");
        }
        public static void student(int phoneno)
        {
            int age = 0;//local variable
            age = age + 10;
            Console.WriteLine("Student age is {0} and phone number is {1} ",age ,phoneno);
        }
    }

}
