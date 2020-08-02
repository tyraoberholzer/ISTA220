using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Programming_Ex04_Tyra
{
    class Program
    {
        static void Main(string[] args)
        {
            calcCirc();
            //calcVol();
            //calcTri();
            //calcQuad();
        }

        private static void calcCirc()
        {
            int num;
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius ");
            string strradius = Console.ReadLine();
            try
            {
                num = int.Parse(strradius);
                if (num <= 0)
                    throw new Exception("Your number must be a positive number");
                double circumference = 2 * Math.PI * num;
                if (double.IsInfinity(circumference))
                    throw new DivideByZeroException();
                Console.WriteLine($"Circumference is {circumference}");
                double area = Math.PI * num * num;
                Console.WriteLine($"The area is {area}");
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                calcCirc();
            }
            catch (InvalidOperationException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                calcCirc();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                calcCirc();
            }
            finally
            {
                Console.WriteLine("Your numbers are okay");
            }
        }
    }
}
