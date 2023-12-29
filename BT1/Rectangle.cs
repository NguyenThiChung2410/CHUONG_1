using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Rectangle
    {
        private double length;
        private double width;
        public Rectangle()
        {
            length = 1.0;
            width = 1.0;
        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public void setLength(double length)
        {
            this.length = length;
        }
        public double getLength()
        {
            return length;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
        public double getWidth()
        {
            return width;
        }
        public double findArea()
        {
            return length * width;
        }
        public double findPerimeter()
        {
            return (length + width) * 2;
        }
    }
}
