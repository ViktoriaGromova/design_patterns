using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Decorator : ICurve
    {
        protected int MaxLenght; //для задания граничного значения
        protected ICurve rCurve;

        public Decorator(ICurve rCurve, int MaxLenght)
        {
            this.rCurve = rCurve;
            this.MaxLenght = MaxLenght;
        }
        public abstract IPoint GetPoint(double t);
    }
}