using System;

namespace Parameters
{
    class WrappedInt
    {
        public int Number;
        public static void Reference(WrappedInt param)
        {
            Console.WriteLine($"   In method Reference param is {param}");
            param.Number = 42;
            Console.WriteLine($"   In method Reference param is now {param}");
        }
    }
}
