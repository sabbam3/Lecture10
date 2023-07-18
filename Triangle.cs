using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10
{
    public class Triangle : Shape
    {
        public int thirdSide;
        public override void Rectangle(int x, int y)
        {
            base.Rectangle( x, y );
            Console.WriteLine( x + y + thirdSide );
        }
        public double TriangleSizes(int baSe, int  height)
        {
            double area = (double) baSe*height/2;
            return area;
        }
        public int TriangleSizes(int firstSide, int secondSide, int thirdSide)
        {
            return firstSide + secondSide + thirdSide;
        }
    }
}
