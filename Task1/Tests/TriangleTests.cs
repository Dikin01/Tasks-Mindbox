using Xunit;
using Geometry.Shapes;
using System;

namespace Geometry.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void FindAreaEqual_217dot771()
        {
            //Arrange
            Shape shape = new Triangle(20, 23, 35);

            //Act
            double area = shape.FindArea();

            //Assert
            Assert.Equal(217.771, area, 3);
        }

        [Fact]
        public void FindAreaEqual_6()
        {
            //Arrange
            Shape shape = new Triangle(4, 3, 5);

            //Act
            double area = shape.FindArea();

            //Assert
            Assert.Equal(6, area);               
        }

        [Fact]
        public void CreateTriangle_True()
        {
            //Arrange
            Triangle triangle;

            //Act
            triangle = new Triangle(3, 4, 5);

            //Assert
            Assert.Equal(3, triangle.A);
            Assert.Equal(4, triangle.B);
            Assert.Equal(5, triangle.C);
        }

        [Fact]
        public void CreateTriangle_GetArgumentException()
        {
            //Arrange
            Triangle shape;

            //Act
            Action act = () => shape = new Triangle(20, 4, 10);
            
            //Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void CheckRightTriangle_True()
        {
            //Arrange
            Triangle circle = new Triangle(3, 4, 5);

            //Act
            bool rightTriangle = circle.IsRightTriangle();

            //Assert
            Assert.True(rightTriangle);
        }

        [Fact]
        public void CheckRightTriangle_False()
        {
            //Arrange
            Triangle circle = new Triangle(3, 4, 4);

            //Act
            bool rightTriangle = circle.IsRightTriangle();

            //Assert
            Assert.False(rightTriangle);
        }
    }
}