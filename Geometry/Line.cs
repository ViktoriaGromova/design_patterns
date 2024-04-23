using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Line : ACurve
    {
        public Line(IPoint a, IPoint b) : base(a, b) {}

        public override IPoint GetPoint(double t)
        {
            Point p = new Point();

            p.X =((1 - t) * a.X + t * b.X);
            p.Y =((1 - t) * a.Y + t * b.Y);

            return p;
        }
    }
}