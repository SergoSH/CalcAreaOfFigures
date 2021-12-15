using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcArea
{
    public class Triangle : Figure
    {
        public Triangle(decimal s1, decimal s2, decimal s3)
        {
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
        }
        public decimal Side1 { get; set; }
        public decimal Side2 { get; set; }
        public decimal Side3 { get; set; }

        public override string Name => "Triangle";

        /// <summary>
        /// Calculates area fo the triangle by Gerone's method
        /// </summary>
        /// <returns></returns>
        public override decimal GetArea()
        {
            if (this.IsCorrect())
            {
                decimal HalfOfPerimeter;
                HalfOfPerimeter = (Side1 + Side2 + Side3) / 2;
                decimal area = (decimal)Math.Sqrt((double)(HalfOfPerimeter * (HalfOfPerimeter - Side1) * (HalfOfPerimeter - Side2) * (HalfOfPerimeter - Side3)));
                return area;
            }
            else
            {
                throw new ArgumentException("Incorrect parameters of a Triangle!");
            }
        }

        /// <summary>
        /// Checks if sides of the triangle are correct or not
        /// </summary>
        /// <returns></returns>
        public override bool IsCorrect()
        {
            return (Side1>0 && Side2>0 &&Side3>0 && Side1 + Side2 > Side3 && Side1 + Side3 > Side2 && Side2 + Side3 > Side1);
        }

        /// <summary>
        /// Checks if a triangle has a right angle or not
        /// </summary>
        /// <returns></returns>
        public bool HasRightAngle()
        {
            return (Side1 * Side1 == Side2 * Side2 + Side3 * Side3) ||
                (Side2 * Side2 == Side1 * Side1 + Side3 * Side3) ||
                (Side3 * Side3 == Side1 * Side1 + Side2 * Side2);
        }
    }
}
