﻿using System;

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int i = 0;
            Console.WriteLine($"In Part 1 i is {i}");
            Pass.Value(i);
            Console.WriteLine($"In Part 1 i is still {i}");
            Console.WriteLine("===============================");

            WrappedInt wi = new WrappedInt();
            Console.WriteLine($"In Part 2 wi.Number is {wi.Number}");;
            Pass.Reference(wi);
            Console.WriteLine($"In Part 2 wi.Number is now {wi.Number}");
            Console.WriteLine("===============================");
            
            Console.WriteLine($"In Part 3 i is {i}");
            Pass.Value1(ref i);
            Console.WriteLine($"In Part 3 i is still {i}");
            Console.WriteLine("===============================");

        }

        static void Main(string[] args)
        {
                doWork();
        }
    }
}


//Line 1-so we can access the class
//namespace create a namespace name Parameters
//class program creates a class name Program