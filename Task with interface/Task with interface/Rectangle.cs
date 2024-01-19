using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_with_interface
{
    internal class Rectangle:IcalculateShape
    {


        public double Height;
        public double Width;


        public  double CalculateAreaOfShape()
        {
            double area = Height * Width;

            return area;

        }
    }
}
