using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz03
{
    class Program
    {
        private static object result;

        static void Main(string[] args)
        {
            daReprical();
        }

        private static void daReprical()
        {
            int num;
            Console.Write("To calculate the reciprocal of an integer, enter a positive integer: ");
            string usernum = Console.ReadLine();
            try
            {
                num = int.Parse(usernum);
                if (num < 0)
                    throw new Exception("Your number must be a positive number");
                double recip = (double)1.0 / num;
                if (double.IsInfinity(recip))
                    throw new DivideByZeroException("Attempted to divide by zero");
                Console.WriteLine($"The reciprocal is {recip}");
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                daReprical();
            }
            catch (DivideByZeroException dEx)
            {
                Console.WriteLine(dEx.Message);
                daReprical();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                daReprical();
            }
        }
    }
}
