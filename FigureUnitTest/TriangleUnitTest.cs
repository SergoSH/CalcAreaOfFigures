using System;
using Xunit;
using CalcArea;

namespace FigureUnitTest
{
    public class TriangleUnitTest
    {
        [Fact]
        public void IsCorrectChecking()
        {
            Triangle triangle = new(3,4,5);
            Assert.True(triangle.IsCorrect());
        }

        [Fact]
        public void IsIncorrectLengthOfSidesChecking()
        {
            Triangle triangle = new(2,3,6); 
            Assert.False(triangle.IsCorrect());
        }

        [Fact]
        public void IsZeroLengthOfSideChecking()
        {
            Triangle triangle = new(2, 3, 0);
            Assert.False(triangle.IsCorrect());
        }

        [Fact]
        public void CalcAreaChecking()
        {
            Triangle triangle = new(3,4,5);
            Assert.True(triangle.GetArea() == (decimal)6);
        }

        [Fact]
        public void CalcAreaTrowExceptionChecking()
        {
            Triangle triangle = new(2,3,-1); 
            Assert.Throws<ArgumentException>(() => triangle.GetArea());
        }

        [Fact]
        public void HasRightAngleChecking()
        {
            Triangle triangle = new(3, 4, 5);
            Assert.True(triangle.HasRightAngle());
        }

        [Fact]
        public void HasNotRightAngleChecking()
        {
            Triangle triangle = new(3, 3, 5);
            Assert.False(triangle.HasRightAngle());
        }
    }
}
