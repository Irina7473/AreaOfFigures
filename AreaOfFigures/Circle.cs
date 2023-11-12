using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    public class Circle : GeometricFigure
    {
        private const double _pi = 3.14159;
        private double _radius;
        public double Radius { get; }
        
        public Circle(double radius) 
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException(nameof(radius));
            Radius = radius;
        }

        public override double FindArea()
        {
            return _pi * Math.Pow(Radius,2);
        }

        public override double FindPerimeter()
        {
            return 2 * _pi * Radius;
        }
    }
}
