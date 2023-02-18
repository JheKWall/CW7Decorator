using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW7Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextField textfield = new TextField(10, 8);
            BorderDecorator borderdecor = new BorderDecorator(textfield);
            ScrollDecorator scrolldecor = new ScrollDecorator(borderdecor);
            CookieDecorator cookiedecor = new CookieDecorator(scrolldecor);

            cookiedecor.draw();

            Console.ReadKey();
        }
    }
}
