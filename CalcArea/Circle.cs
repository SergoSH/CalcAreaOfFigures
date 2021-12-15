using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcArea
{
    public class Circle : Figure
    {
        public decimal Radius { get; set; }
        public override string Name => "Circle";

        public Circle(decimal rad)
        {
            Radius = rad;  
        }
        /// <summary>
        /// Calculates area of the circle by its radius
        /// </summary>
        /// <returns></returns>
        public override decimal GetArea()
        {
            if (IsCorrect())
            {
                return Decimal.Round((decimal)(Math.PI * Math.Pow((double)Radius, 2)), 2);
            }
            else
            {
                throw new ArgumentException("Incorrect parameter of Circle");
            }
        }
        /// <summary>
        /// Check if the radius of the circle is correct
        /// </summary>
        /// <returns></returns>
        public override bool IsCorrect()
        {
            return Radius > 0;
        }
    }
}
