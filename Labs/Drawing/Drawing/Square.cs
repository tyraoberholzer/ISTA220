using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing 
{
    class Square : DrawingShape, IDraw, IColor
    {
        private Rectangle rect = null;
        public Square(int sL) : base(sL)
        {
        }
        public override void Draw(Canvas canvas)
        {
            if (shape != null)
            {
                canvas.Children.Remove(shape);
            }
            else
            {
                shape = new Rectangle();
            }
            base.Draw(canvas);
        }
    }
}

//private int sideLength; they are fields. reference type
//private int locX = 0; value type
//private int locY = 0; value type
//private Rectangle rect = null; reference type
//public Square(int sideLength) is a constructor because it has the same name as the class and it does not have a return type

