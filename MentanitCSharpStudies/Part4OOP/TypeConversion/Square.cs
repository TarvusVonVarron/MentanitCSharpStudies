using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4OOP.TypeConversion
{
    internal class Square : Shape
    {
        public override double GetPerimeter(double side) => side * 4;
    }
}
