using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Visual
{
    public class VisualCurve : ICurve, IDrawable
    {
        private const int n = 20;
        protected float width = 1;
        protected ICurve curve;

        public VisualCurve(ICurve c_)
        {
            this.curve = c_;
        }

        public ICurve GetCurve(){
            return curve;
        }

        public IPoint GetPoint(double t)
        {
            return curve.GetPoint(t);
        }

        public void Draw(IDrawer d)
        {
            d.DrawFirstPoint(curve);
            d.DrawLastPoint(curve);
            double t = (double)1 / n;

            for (int i = 1; i <= n; ++i)
            {
                d.DrawSegment(curve, (double)(i - 1) * t, (double)(i * t));
            }
        }
    }

}