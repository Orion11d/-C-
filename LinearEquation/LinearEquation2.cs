using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearEquation
{
    public class LinearEquation2
    {
        public LinearEquation2()
        {
            A = B = 0;
            X = null;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double? X { get; private set; }

        public double Solve()
        {
            if (A == 0)
            {
                if (B == 0)
                    return -1;
                else
                    return 0;
            }
            else
                X = -B / A;
            return 1;
        }
    }
}
