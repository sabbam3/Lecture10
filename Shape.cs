using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10
{
    public class Shape
    {
        public virtual void Rectangle(int x, int y)
        {
            Console.WriteLine(2 *( x + y ));
        }
    }
}
