using System;

namespace Classes
{
    class Program
    //declares a class named program
    {
        static void doWork()
        {
            Console.WriteLine("Running class program...");
            //int nicki = 42;
            //int = integer which is a type, nicki is a name, = is an assignment operator
            Point origin = new Point();
            //it instantiates a point object name origin
            //Point() is a constructor which returns a memory address
            //new allocates memory and returns a memory address
            //origin is a name, and Point is a type
            Point bottomRight = new Point(1366, 768);
            //constructor point has integers of 1366, 786 allocated memory by new assigned to the name bottomright
            //it instantiates a point object name bottomright
            Point proof = new Point();
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine($"Distance is: {distance}");
            Point Nicki = new Point(0, 0);
            Point Dwaine = new Point(3, 4);
            distance = Nicki.DistanceTo(Dwaine);
            Console.WriteLine($"Distance between nicki and dwaine is: {distance}");
            Point Matt = new Point(6, 25);
            Console.WriteLine($"Number of Point objects: {Point.ObjectCount()}");
        }

        static void Main(string[] args)
        //void is the return type
        {
                doWork();                
        }
    }
}
