using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Visual
{
    public interface IDrawer
    {
        public void DrawFirstPoint(ICurve C);
        public void DrawLastPoint(ICurve C);
        public void DrawSegment(ICurve C, double t1, double t2);
    }
}