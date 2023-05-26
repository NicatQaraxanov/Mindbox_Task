using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTask
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Triangle : IShape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        public bool IsRightAngled()
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);
            double hypotenuse = sides[2];
            double sumOfSquares = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);

            return Math.Pow(hypotenuse, 2) == sumOfSquares;
        }
    }
}
