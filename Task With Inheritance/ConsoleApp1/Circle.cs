using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Circle:Shape
    {

        public double Radius;


        public override double Calculate()
        {
            double p = 3.14;
            double Area = (Radius * Radius)*p;

            return Area;


        }
    }
}
