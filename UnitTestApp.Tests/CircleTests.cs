using AreaOfFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestApp.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Circle()
        {
            double radius = 2.5;
            var circle = new Circle(radius);

            Assert.True(circle!=null);
        }

        [Fact]
        public void FindArea()
        {
            double radius = 2.5;
            var circle = new Circle(radius);
            double expected = 19.6349375;

            double result = circle.FindArea();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindPerimeter()
        {
            double radius = 2.5;
            var circle = new Circle(radius);
            double expected = 15.70795;

            double result = circle.FindPerimeter();
            Assert.Equal(expected, result);
        }

    }
}
