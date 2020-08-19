using System;

namespace ParamsArray
{
    class Util
    {
        public static int Sum(params int[] paramList)
        {
            Console.WriteLine("Using Parameter Array.");
            if (paramList == null)
                throw new ArgumentException("Util.Sum: null Parameter List");
            if (paramList.Length == 0)
                throw new ArgumentException("Util.Sum: empty Parameter List");
            int sumTotal = 0;
            foreach (int i in paramList)
                sumTotal += i;
            return sumTotal;
        }
        public static int Sum(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
        {
            Console.WriteLine("Using optional parameters");
            int sumTotal = param1 + param2 + param3 + param4;
            return sumTotal;
        }
        public int Total(int lhs, int rhs)
        {
            return lhs + rhs;
        }
    }
}

//public is a visibly identifier
//static is a class method; create the class method/member
//instance member for that specific object only
//integer is a return type; returns an integer
//Sum is the name of int
//params is a keyword that indicates this method is going to be able to 
//  take an arbitrary amount of arguments
//int[] integer array
//paramList represents a container for all the arguments you will passs
//foreach is a loop
//void is the return type doesn't return anything
//string is the type of the parameter
//noiseToMakeWhenStopping name of parameter
//virtual - tells  users of this class that they are going to override the method of drive
//Console.WriteLine("Testing polymorphism");
//            Vehicle v = myCar;
//            v.Drive();
//            v = myPlane;
//            v.Drive();
//            v = tyra;
//            v.Drive();
//the first v.Drive is referencing myCar so using that Drive statement
//the second v.Drive is referencing myPlan using that Drive statement
//the third v.Drive is referencing tyra using that Drive statement