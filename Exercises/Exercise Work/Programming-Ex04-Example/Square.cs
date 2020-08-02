using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Square
    {
        int side;
        public Square (int s)
        {
            side = s;
        }
        public int area(int side)
        {
            return side * side;
        }
        public string Hello()
        {
            return $"This is square and my side is {side}";
        }
    }
}
