using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265proj08.models
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width  { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        public double GetArea()
        {
            return Length * Width;
        }
    }
}
