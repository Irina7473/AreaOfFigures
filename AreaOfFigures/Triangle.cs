using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    public class Triangle : GeometricFigure
    {
        private double _side1;
        public double Side1 { get; }

        private double _side2;
        public double Side2 { get; }        

        private double _side3;
        public double Side3 { get; }
        

        public Triangle(double side1, double side2, double side3)
        {            
            if (side1 > 0 && side2 > 0 && +side3 > 0
                && side1 < side2 + side3
                && side2 < side1 + side3
                && side3 < side2 + side1)
            {
                Side1 = side1;
                Side2 = side2;
                Side3 = side3;
            }
            else throw new ArgumentException(String.Format("Не соблюдается условие (длины сторон) для создание треугольника"));
        }

        public override double FindArea()
        {          
            var halfP = FindPerimeter()/ 2;
            return Math.Sqrt(halfP*(halfP-Side1) * (halfP - Side2) * (halfP - Side3));
        }

        public override double FindPerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public bool RectangularTriangle()
        {
            var square1 = Side1 * Side1;
            var square2 = Side2 * Side2;
            var square3 = Side3 * Side3;
            
            if (square1 == square2 + square3 
                || square2 == square1 + square3 
                || square3 == square2 + square1) 
                return true;
            else return false;
        }
    }
}
