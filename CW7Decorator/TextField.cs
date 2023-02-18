using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW7Decorator
{
    class TextField : IWidget
    {
        private int width;
        private int height;

        public TextField(int w, int h)
        {
            width = w;
            height = h;
        }

        public void draw()
        {
            Console.WriteLine("TextField: " + width + ", " + height);
        }
    }
}
