using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrograms
{
    internal class InstanceVariable
    {
        public int engMarks;
        public int mathMarks;
        public int phyMarks;

        public void MarksDetails()
        {
            Console.WriteLine("English:{0}  Maths:{1}  Physics:{2}",engMarks,mathMarks,phyMarks);
        }
    }
}
