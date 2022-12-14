using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConcepts
{
    internal class ArrayConcepts
    {
        public static void TestArray()
        {
            Console.WriteLine("Please enter size of array : ");
            int size =Convert.ToInt32(Console.ReadLine());
            int[] num = new int[size];
            Console.WriteLine("Reading input from user and storing into an array");
            for (int i = 0; i < size; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Displaying array element");
            IterateOverArray(num);
            Console.WriteLine("\nUploading the value of 3rd element enter the number : ");
            
            num[2] = Convert.ToInt32(Console.ReadLine());
            IterateOverArray(num);
        }

        public static void IterateOverArray(int[] num)
        {
            for(int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
        }
    }
}
