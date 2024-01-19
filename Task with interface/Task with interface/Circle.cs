using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_with_interface
{
    internal class Circle:IcalculateShape
    {

        public double Radius;

        

        public  double CalculateAreaOfShape()
        {
            double p = 3.14;

            double Area = (Radius * Radius) * p;

            return Area;
        }

    }
}
