using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LinearEquation1 LE = new LinearEquation1(3, 4);
            LinearEquation2 le2 = new LinearEquation2();
            le2.A = double.Parse(Console.ReadLine());
            le2.B = double.Parse(Console.ReadLine());
    
            switch (le2.Solve())
            {
                case -1: Console.WriteLine("Infinity"); break;
                case 0: Console.WriteLine("No Solve"); break;
                default: Console.WriteLine($"One {le2.X}"); break;
            }
            switch (LE.Calculation())
            {
                case -1: Console.WriteLine("Infinity"); break;
                case 0: Console.WriteLine("No Solve"); break;
                default: Console.WriteLine($"One {LE.x}");break;
            }
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
