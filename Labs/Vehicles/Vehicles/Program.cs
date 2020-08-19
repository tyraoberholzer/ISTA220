using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("This is the Vehicles Lab.");
            Console.WriteLine("==============================================================");
            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr");
            Console.WriteLine("==============================================================");
            Console.WriteLine("Journey by car:");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");
            Console.WriteLine("==============================================================");
            Console.WriteLine("Journey by truck:");
            Truck tyra = new Truck();
            tyra.StartEngine("Vroom Vroom");
            tyra.Haul();
            tyra.Drive();
            tyra.Tows();
            tyra.StopEngine("Klunk Klunk");
            Console.WriteLine("==============================================================");
            Console.WriteLine("Journey by boat:");
            Boat Titantic = new Boat();
            Titantic.StartEngine("Swish Swish");
            Titantic.Sail();
            Titantic.Drive();
            Titantic.Floats();
            Titantic.StopEngine("Glug Glug");
            Console.WriteLine("==============================================================");
            Console.WriteLine("Testing polymorphism");
            Vehicle v = myCar;
            v.Drive();
            v = myPlane;
            v.Drive();
            v = tyra;
            v.Drive();
            Console.WriteLine("==============================================================");
        }

        static void Main()
        {
            doWork();           
        }
    }
}
