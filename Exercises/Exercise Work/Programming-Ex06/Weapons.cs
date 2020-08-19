using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Ex06
{
    class Weapons : Personnel
    {
        public override void name()
        {
            Console.WriteLine("A. M16A2 5.56 Rifle");
            Console.WriteLine("B. M2 .50 Caliber Machine Gun");
            Console.WriteLine("C. M4 Carbine");
            Console.WriteLine("D. MK19 Grenade Machine Gun");
        }
        public void maxRange()
        {
            Console.WriteLine("A. 550 meters");
            Console.WriteLine("B. 6,800 meters");
            Console.WriteLine("C. 600 meters");
            Console.WriteLine("D. 2,212 meters");
        }
        public void length()
        {
            Console.WriteLine("A. 39.63 inches");
            Console.WriteLine("B. 65 inches");
            Console.WriteLine("C. 33 inches (stock extended)");
            Console.WriteLine("D. 43.1 inches");
        }
        public void caliber()
        {
            Console.WriteLine("A. 5.56x45 mm");
            Console.WriteLine("B. .50 BMG");
            Console.WriteLine("C. 5.56x45 mm");
            Console.WriteLine("D. 40 mm");
        }
    }
}
