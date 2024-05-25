using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class HorizontalReflection : Decorator
    {
        public HorizontalReflection(ICurve Curve, int width) : base(Curve, width) { }

        public override IPoint GetPoint(double t)
        {
            IPoint basePoint = rCurve.GetPoint(t);

            Point mirroredPoint = new Point();
            mirroredPoint.X = MaxLenght - basePoint.X;
            mirroredPoint.Y = basePoint.Y;

            return mirroredPoint;
        }
    }
}