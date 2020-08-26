using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quiz_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This is C Sharp quiz 2.");
            Console.Write("Please enter the number of integers to add:");
            string strNumber = Console.ReadLine();
            int end = Int32.Parse(strNumber);
            int start = 0;
            int sum = 0;
            sum = GetSums(start, end, sum);
            Console.WriteLine($"the sum is {sum}");
        }

        private static int GetSums(int start, int end, int sum)
        {
            Console.WriteLine($"GetSums({start},{end},{sum})");
            if (start >= end)
                return sum;
            else
                return GetSums(++start, end, sum + start);
        }

        //private static int GetSums(int start, int end, int sum)
        //{
        //    Console.WriteLine($"The sum of {sum} and {start} is {sum + start}");
        //    if (end <= 0)
        //        return sum;
        //    else
        //        return GetSums(start + sum, --end, ++sum);
        //}

    }
}
