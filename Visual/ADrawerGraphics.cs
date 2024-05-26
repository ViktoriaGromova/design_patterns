using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Visual
{
    public abstract class ADrawerGraphics : IDrawer
    {
        protected Graphics g;
        
        public abstract void DrawFirstPoint(ICurve C);
        public abstract void DrawLastPoint(ICurve C);
        public abstract void DrawSegment(ICurve C, double t1, double t2);
    }
}