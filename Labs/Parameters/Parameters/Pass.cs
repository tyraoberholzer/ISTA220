using System;

namespace Parameters
{
    class Pass
    {
        public static void Reference(WrappedInt param)
        {
            Console.WriteLine($"   In method Reference param is {param}");
            param.Number = 42;
            Console.WriteLine($"   In method Reference param is now {param}");
        }
        public static void Value(int param)
        {
            Console.WriteLine($"   In method Value param is {param}");
            param = 42;
            Console.WriteLine($"   In method Value param is now {param}");
        }
        public static void Value1(ref int param)
        {
            Console.WriteLine($"   In method Value1 param is {param}");
            param = 42;
            Console.WriteLine($"   In method Value1 param is now {param}");
        }


    }
}
