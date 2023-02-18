using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW7Decorator
{
    class BorderDecorator : Decorator
    {
        public BorderDecorator(IWidget w) : base(w)
        {
            wid = w;
        }

        public void draw()
        {
            wid.draw();
            Console.WriteLine("Border Decorator");
        }
    }
}
