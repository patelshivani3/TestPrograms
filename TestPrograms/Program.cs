using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD");
            Addition A = new Addition();
            A.Add();
            Substraction S = new Substraction();
            S.Sub();
            Multiplication M = new Multiplication();
            M.Mul();
            Division D = new Division();
            D.Div();
            Console.ReadLine();

        }
    }
}
