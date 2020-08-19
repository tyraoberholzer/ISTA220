using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Ex06
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Tyra Oberholzer's Programming Exercise 06.");
            Console.WriteLine("=======================================================");
            Console.WriteLine("UNIT PERSONNEL FILES");
            Personnel newPersonnel = new Personnel();
            Console.WriteLine("Name");
            newPersonnel.name();
            Console.WriteLine(" ");
            Console.WriteLine("Rank");
            newPersonnel.rank();
            Console.WriteLine(" ");
            Console.WriteLine("MOS");
            newPersonnel.mos();
            Console.WriteLine(" ");
            Console.WriteLine("=======================================================");
            Console.WriteLine("VEHICLES");
            Vehicles newVehicles = new Vehicles();
            Console.WriteLine("Name");
            newVehicles.name();
            Console.WriteLine(" ");
            Console.WriteLine("Engine");
            newVehicles.engine();
            Console.WriteLine(" ");
            Console.WriteLine("Speed");
            newVehicles.speed();
            Console.WriteLine(" ");
            Console.WriteLine("Armament");
            newVehicles.armament();
            Console.WriteLine(" ");
            Console.WriteLine("Range");
            newVehicles.range();
            Console.WriteLine(" ");
            Console.WriteLine("=======================================================");
            Console.WriteLine("WEAPONS");
            Weapons newWeapons = new Weapons();
            Console.WriteLine("Name");
            newWeapons.name();
            Console.WriteLine(" ");
            Console.WriteLine("Max Range");
            newWeapons.maxRange();
            Console.WriteLine(" ");
            Console.WriteLine("Length");
            newWeapons.length();
            Console.WriteLine(" ");
            Console.WriteLine("Caliber");
            newWeapons.caliber();
            Console.WriteLine(" ");
            Console.WriteLine("=======================================================");
        }
        static void Main(string[] args)
        {
            doWork();
        }
    }
}
