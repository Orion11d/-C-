using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearEquation
{
    public class LinearEquation1
    {

        public double a, b, x;
        public LinearEquation1(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Calculation()
        {
            if (a == 0)
            {
                if (b == 0)
                    return -1;
                else
                    return 0;
            }
            else
            {
                return x = -b / a;
            }
        }
    }
}
