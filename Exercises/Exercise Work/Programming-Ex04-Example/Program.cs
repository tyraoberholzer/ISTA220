using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Square Debra = new Square(33);
            int area = Debra.area(33);
            Console.WriteLine($"Area is {area}");
            string hi = Debra.Hello();
            Console.WriteLine(hi);

            Circle Arnold = new Circle();
            double area1 = Arnold.area(66);
            Console.WriteLine($"Area is {area}");
            string howdy = Arnold.Greeting();
            Console.WriteLine(howdy);
        }
    }
}
