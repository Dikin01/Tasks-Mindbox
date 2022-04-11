using Geometry.Shapes;
using System;
using Xunit;

namespace Geometry.Tests
{
    public class CircleTests
    {
        [Fact]
        public void FindAreaEqual_1055655dot004()
        {
            //Arrange
            Shape circle = new Circle(579.677);

            //Act
            double area = circle.FindArea();

            //Assert
            Assert.Equal(1055655.004, area, 3);
        }


        [Fact]
        public void FindAreaEqual_12dot566()
        {
            //Arrange
            Shape circle = new Circle(2);

            //Act
            double area = circle.FindArea();

            //Assert
            Assert.Equal(12.566, area, 3);
        }

        [Fact]
        public void CreateCircle_True()
        {
            //Arrange
            Circle circle;

            //Act
            circle = new Circle(5);

            //Assert
            Assert.Equal(5, circle.Radius);
        }

        [Fact]
        public void CreateCircle_GetArgumentException()
        {
            //Arrange
            Circle circle;

            //Act
            Action act = () => circle = new Circle(-4);

            //Assert
            Assert.Throws<ArgumentException>(act);
        }
        
    }
}
