using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Ex06
{
    class Personnel
    {
        public virtual void name()
        {
            Console.WriteLine("A. Oberholzer, Tyra");
            Console.WriteLine("B. Smith, Bob");
            Console.WriteLine("C. Doe, Jane");
            Console.WriteLine("D. Longfellow, Jameson");
        }
        public void rank()
        {
            Console.WriteLine("A. E-4/Corporal");
            Console.WriteLine("B. E-2/Private First Class");
            Console.WriteLine("C. E-5/Sergeant");
            Console.WriteLine("D. E-7/Gunnery Sergeant");
        }
        public void mos()
        {
            Console.WriteLine("A. 0671/Data Network Specialist");
            Console.WriteLine("B. 0631/Network Administrator");
            Console.WriteLine("C. 0621/Field Radio Operator");
            Console.WriteLine("D. 0679/Data Systems Chief");
        }
    }
}
