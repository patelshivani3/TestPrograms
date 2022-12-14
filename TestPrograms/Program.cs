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
           
            Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division\n5.Local Variables\n6.Static Variable\n7.Instance Variable\n\nChoose the program from above options: ");
            int option = Convert.ToInt32(Console.ReadLine());
            
            switch (option)
            {

                case 1:
                    Addition A = new Addition();
                    A.Add();
                    break;
               
                case 2:
                    Substraction S = new Substraction();
                    S.Sub();
                    break;
               
                case 3:
                    Multiplication M = new Multiplication();
                    M.Mul();
                    break;
                
                case 4:
                    Division D = new Division();
                    D.Div();
                    break;
                
                case 5:
                    LocalVariables l = new LocalVariables();
                    LocalVariables lv = new LocalVariables(20);
                    LocalVariables.student(1234567890);
                    break;
                
                case 6:
                    StaticVariable.number = 23;
                    Console.WriteLine(StaticVariable.number);
                    break;

                case 7:
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
                    break;

                default:
                    Console.WriteLine("Please choose the number within the given option ");
                    break;
            }
            Console.ReadLine();


        }
    }
}
