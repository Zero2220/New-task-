using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Rectangle:Shape
    {

        public double Length;

        public double Width;

        public override double Calculate()
        {
            double Area = Length * Width;

            return Area;
        }

    }
}
