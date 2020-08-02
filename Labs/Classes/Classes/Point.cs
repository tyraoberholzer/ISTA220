using System;
//using statment so we can use namespace class

namespace Classes
//name of the program, namespace is a container inside container have multiple classes
{
    class Point
    //declares a class name Point
    {
        //this creates instance fields x and y
        int x;
        int y;
        //int x and int y are declaring them
        private static int numOfPts = 0;
        //declares a class field of instance
        //every instance of a type has all the instance fields, all of the instances of the class share the same class field
        public Point()
        //Point() is the constructor
        {
            x = -1;
            y = -1;
            numOfPts++;
            Console.WriteLine("Default constructor called");
            Console.WriteLine($"Default x is {x} and default y is {y}");
        }
        public Point(int xVar, int yVar)
        //Point() is a constructor because it has the same name as the class and has no return type
        {
            x = xVar;
            y = yVar;
            numOfPts++;
            Console.WriteLine($"x:{x}, y:{y}");
        }
        public double DistanceTo(Point other)
        //double is a return type DistanceTo is a name of a method the parameter is the name Other of type Point
        {
            int xDiff = x - other.x;
            int yDiff = y - other.y;
            //other is an instance of type Point and x is an instance variable of the other object
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
        public static int ObjectCount()
        //it declares a method name ObjectCount with return value of integer and no parameters
        {
            return numOfPts;
        }              
    }
}
