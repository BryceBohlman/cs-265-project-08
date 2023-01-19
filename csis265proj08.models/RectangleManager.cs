using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265proj08.models
{
    public class RectangleManager
    {
        private List<Rectangle> rectangles;

        public RectangleManager()
        {
            rectangles = new List<Rectangle>();
        }

        public void AddRectangle(double length, double width)
        {
            rectangles.Add(new Rectangle(length, width));
        }

        public double GetTotalPerimeter()
        {
            double sum = 0;

            foreach(Rectangle rectangle in rectangles)
            {
                sum += rectangle.GetPerimeter();
            }

            return sum;
        }

        public double GetTotalArea()
        {
            double sum = 0;

            foreach (Rectangle rectangle in rectangles)
            {
                sum += rectangle.GetArea();
            }

            return sum;
        }

        public double GetAveragePerimeter()
        {
            double sum = 0;
            int count = 0;

            foreach (Rectangle rectangle in rectangles)
            {
                sum += rectangle.GetPerimeter();
                count++;
            }

            return (sum / count);
        }

        public double GetAverageArea()
        {
            double sum = 0;
            int count = 0;

            foreach (Rectangle rectangle in rectangles)
            {
                sum += rectangle.GetArea();
                count++;
            }

            return (sum / count);
        }
    }
}
