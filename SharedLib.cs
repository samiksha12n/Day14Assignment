using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibDay14Assignment
{
    public class SharedLib
    {
        public double Square(double length)
        {
            double area = length * length;
            return area;
        }
        public double Rectangle(double length,double width)
        {
            double area = length * width;
            return area;
        }
        public double Triangle(double bas,double height)
        {
            double area = (bas*height)/2;
            return area;
        }
        public double Circle(double radius)
        {
            double area = 3.14159*radius;
            return area;
        }
    }
}
