using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4OOP.TypeConversion
{
    internal class Circle : Shape
    {
        public override double GetPerimeter(double radius) => radius * 2 * Math.PI;
    }
}
