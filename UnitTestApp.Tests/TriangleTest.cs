using AreaOfFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestApp.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void Triangle()
        {
            double side1 = 5;
            double side2 = 4;
            double side3 = 3;
            var triangle = new Triangle(side1, side2, side3);

            Assert.True(triangle != null);
        }

        [Fact]
        public void FindArea()
        {
            double side1 = 5;
            double side2 = 4;
            double side3 = 3;
            var triangle = new Triangle(side1, side2, side3);
            double expected = 6;

            double result = triangle.FindArea();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindPerimeter()
        {
            double side1 = 5;
            double side2 = 4;
            double side3 = 3;
            var triangle = new Triangle(side1, side2, side3);
            double expected = 12;

            double result = triangle.FindPerimeter();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RectangularTriangle()
        {
            double side1 = 5;
            double side2 = 4;
            double side3 = 3;
            var triangle = new Triangle(side1, side2, side3);

            Assert.True(triangle.RectangularTriangle());           
        }
    }
}
