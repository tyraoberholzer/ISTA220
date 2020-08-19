using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Ex06
{
    class Vehicles : Personnel
    {
        public override void name()
        {
            Console.WriteLine("A. M1126 Stryker Combat Vehicle");
            Console.WriteLine("B. M1A2 Abrams Main Battle Tank");
            Console.WriteLine("C. M2/M3 Bradley Fighting Vehicle");
            Console.WriteLine("D. M88A2 Hercules Recovery Vehicle");
        }
        public void engine()
        {
            Console.WriteLine("A. Caterpillar C7, 350 hp");
            Console.WriteLine("B. 1500 HP Gas Turbine Engine");
            Console.WriteLine("C. Cummins VTQ-903T Diesel");
            Console.WriteLine("D. 12 cylinder, 1050 HP Air-cooled Diesel Engin");
        }
        public void speed()
        {
            Console.WriteLine("A. 62 MPH");
            Console.WriteLine("B. 42 MPH");
            Console.WriteLine("C. 41 MPH");
            Console.WriteLine("D. 25 MPH");
        }
        public void armament()
        {
            Console.WriteLine("A. M2 .50 cal. Machine gun or MK19 40mm grenade launcher mounted in a Protector (RWS) remote weapon station 50-cal M2 MG and M240 7.62 mm MG.");
            Console.WriteLine("B. 120mm XM245 Smooth Bore Cannon; 7.62 M240 coaxial Machine gun; .50 cal M2 machine gun.");
            Console.WriteLine("C. 25 mm M242 chain gun; TOW anti-tank missile; 7.62 mm M240C machine gun.");
            Console.WriteLine("D. 1x M2.50 caliber machine gun");
        }
        public void range()
        {
            Console.WriteLine("A. 300 miles");
            Console.WriteLine("B. 265 miles");
            Console.WriteLine("C. 300 miles");
            Console.WriteLine("D. 200 miles");
        }
    }
}
