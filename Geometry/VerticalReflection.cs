using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class VerticalReflection : Decorator
    {
        public VerticalReflection(ICurve Curve, int height) : base(Curve, height) {}

        public override IPoint GetPoint(double t)
        {
            IPoint basePoint = rCurve.GetPoint(t);

            Point mirroredPoint = new Point();
            mirroredPoint.X = basePoint.X;
            mirroredPoint.Y = MaxLenght - basePoint.Y;

            return mirroredPoint;
        }
    }
}