using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1srr
{
    public class Body
    {
        public double a { get; set; } = 0;
        public double b { get; set; } = 0;
        public double c { get; set; } = 0;

        public Body(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Max()
        {

            double max = 4 * (a + b + c);

        }
        public double Area()
        {
            return 2 * (a * b + a * c + b * c);
        }


        public string Print()
        {

            return $"{(2 * (a * b + a * c + b * c))}\n" +
                   $"{4 * (a + b + c)}";
            //Без textd не компилируется.
            //Как сделать что бы кнопки нажимались и выводилось не одновременно?
        }
    }
}
