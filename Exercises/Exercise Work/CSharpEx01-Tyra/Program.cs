using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx01_Tyra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart1, circumference and area of a circle.");
            Console.WriteLine("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = (2 * Math.PI) * intradius;
            Console.WriteLine($"The circumference is {circumference}");
            double area = (Math.PI * (intradius * intradius));
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            double volume = ((4 * (Math.PI * (intradius * intradius * intradius)) / 3) / 2);
            Console.WriteLine($"The volume is {volume}");

            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            int a = 0;
            Console.WriteLine("Enter a positive integer: ");
            string stra = Console.ReadLine();
            a = int.Parse(stra);
            int b = 0;
            Console.WriteLine("Enter a positive integer: ");
            string strb = Console.ReadLine();
            b = int.Parse(strb);
            int c = 0;
            Console.WriteLine("Enter a positive integer: ");
            string strc = Console.ReadLine();
            c = int.Parse(strc);
            double p = ((a + b + c) / 2);
            double area1 = (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
            Console.WriteLine($"The area is {area1}");

            Console.WriteLine("\nPart 4, solving the quadratic equation.");
            int d = 0;
            Console.WriteLine("Enter an non-negative integer: ");
            string strd = Console.ReadLine();
            d = int.Parse(stra);
            int e = 0;
            Console.WriteLine("Enter an non - negative integer: ");
            string stre = Console.ReadLine();
            e = int.Parse(strb);
            int f = 0;
            Console.WriteLine("Enter an non - negative integer: ");
            string strf = Console.ReadLine();
            f = int.Parse(strc); 
            double positive_num = (- e + Math.Sqrt((e * e) - 4 * d * f));
            double negative_num = (- e - Math.Sqrt((e * e) - 4 * d * f));
            double denominator = (2 * d);
            Console.WriteLine($"The positive solution is {positive_num / denominator}");
            Console.WriteLine($"The negative solution is {negative_num / denominator}");  


        }
    }
}
