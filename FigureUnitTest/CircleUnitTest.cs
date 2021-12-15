using System;
using Xunit;
using CalcArea;

namespace FigureUnitTest
{
    public class CircleUnitTest
    {
        [Fact]
        public void IsCorrectChecking()
        {
            Circle circle = new(10);
            Assert.True(circle.IsCorrect());
        }

        [Fact]
        public void IsIncorrectChecking()
        {
            Circle circle = new(0); //border value
            Assert.False(circle.IsCorrect());
        }

        [Fact]
        public void CalcAreaChecking()
        {
            Circle circle = new(1); 
            Assert.True (circle.GetArea() == (decimal)3.14);
        }

        [Fact]
        public void CalcAreaTrowExceptionChecking()
        {
            Circle circle = new(0); //border value
            Assert.Throws<ArgumentException>(()=>circle.GetArea());
        }

    }
}
