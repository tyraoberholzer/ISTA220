using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    interface IDraw
    {
        void SetLocation(int xCoord, int yCoord);
        void Draw(Canvas canvas);
    }
}


//void SetLocation(int xCoord, int yCoord); void does not return anything; setlocation is name of method; two parameters
//void Draw(Canvas canvas); void doesn't return anything; method draw draws someting on the canvas;