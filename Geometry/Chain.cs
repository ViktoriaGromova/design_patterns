using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Chain : ICurve
    {
        protected ICurve rCurve1;
        protected ICurve rCurve2;

        public Chain(ICurve rCurve1, ICurve rCurve2)
        {
            this.rCurve1 = rCurve1;
            this.rCurve2 = rCurve2;
        }
        public IPoint GetPoint(double t)
        {
            IPoint basePoint;
            if (t >= 0 && t <= 0.5)
            {   
                basePoint = rCurve1.GetPoint(t);
            }
            else
            {
                basePoint = rCurve2.GetPoint(t);
            }
            Point CurvePoint = new Point(basePoint.X, basePoint.Y);
            return CurvePoint;
        }
    }
}