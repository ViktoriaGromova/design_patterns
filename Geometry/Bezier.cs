using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Bezier : ACurve
    {
        IPoint c, d;

        public Bezier(IPoint a, IPoint b, IPoint c, IPoint d) : base(a, b)
        {
            this.c = c;
            this.d = d;
        }

        public override IPoint GetPoint(double t)
        {
            Point p = new Point();

            p.X = Math.Pow((1 - t), 3) * a.X + 3 * t * Math.Pow((1 - t), 2) * c.X + 3 * Math.Pow(t, 2) * (1 - t) * d.X + Math.Pow(t, 3) * b.X;
            p.Y = Math.Pow((1 - t), 3) * a.Y + 3 * t * Math.Pow((1 - t), 2) * c.Y + 3 * Math.Pow(t, 2) * (1 - t) * d.Y + Math.Pow(t, 3) * b.Y;

            return p;
        }
    }
}