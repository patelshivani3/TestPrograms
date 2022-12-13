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
           /* Addition A = new Addition();
            A.Add();
            Substraction S = new Substraction();
            S.Sub();
            Multiplication M = new Multiplication();
            M.Mul();
            Division D = new Division();
            D.Div();*/
            LocalVariables l = new LocalVariables();
            LocalVariables lv = new LocalVariables(20);
            LocalVariables.student(1234567890);
            
            StaticVariable.number = 23 ;
            Console.WriteLine(StaticVariable.number);

            InstanceVariable obj1 = new InstanceVariable();
            obj1.engMarks = 90;
            obj1.mathMarks = 80;
            obj1.phyMarks = 78;
            obj1.MarksDetails();

            InstanceVariable obj2 = new InstanceVariable();
            obj2.engMarks = 80;
            obj2.mathMarks = 83;
            obj2.phyMarks = 85;
            obj2.MarksDetails();

            Console.ReadLine();


        }
    }
}
