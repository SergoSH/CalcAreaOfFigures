using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcArea
{
    public abstract class Figure
    {
        public abstract string Name { get; }
        public abstract decimal GetArea();
        public abstract bool IsCorrect();
    }
}
