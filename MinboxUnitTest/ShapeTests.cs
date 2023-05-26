using MindboxTask;
using NUnit.Framework;
using System;

namespace MinboxUnitTest
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void Circle_AreaCalculation_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [Test]
        public void Triangle_AreaCalculation_ReturnsCorrectArea()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);
            double expectedArea = 6;

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [Test]
        public void Triangle_IsRightAngled_ReturnsTrueForRightAngledTriangle()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsTrue(isRightAngled);
        }

        [Test]
        public void Triangle_IsRightAngled_ReturnsFalseForNonRightAngledTriangle()
        {
            // Arrange
            double side1 = 2;
            double side2 = 3;
            double side3 = 4;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsFalse(isRightAngled);
        }
    }
}