using System;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("This is Lab 11.");
            Console.WriteLine(Util.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
            // Console.WriteLine("Using parameter list");
            Console.WriteLine(Util.Sum(1));
            Console.WriteLine(Util.Sum(1, 3));
            Console.WriteLine(Util.Sum(1, 3, 5));
            Console.WriteLine(Util.Sum(1, 3, 5, 7));
            Console.WriteLine(Util.Sum(1, 3, 5, 7, 9));
            Console.WriteLine("===================================================");
            Util tyra = new Util();
            Console.WriteLine(tyra.Total(5, 8));
        }

        static void Main()
        {
                doWork();
        }
    }
}


//Console.WriteLine(Util.Sum(null)); (null) means there is no value there 
//                                   Util.Sum is the name of the method
//new returns a new memory address and Util contains an object reference