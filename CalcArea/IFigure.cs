using System;

namespace CalcArea
{
    public interface IFigure
    {
        public string Name { get; }
        public decimal GetArea();
        public bool IsCorrect();
    }
}
