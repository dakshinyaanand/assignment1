using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Shapes
    {
        double area;
        public void DispalyArea(double a)
        {
            area = 3.14 * a * a;
            Console.WriteLine("Area :" + area);
            //Console.WriteLine(DateTime.Now.Month);
        }
        public void DispalyArea(double l, double b)
        {
            area = l * b;
            Console.WriteLine("Area :" + area);
        }
        public void DispalyArea(double h, double b, double half)
        {
            area = half * b * h;
            Console.WriteLine("Area :" + area);
        }
    }
}
