using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Visual
{
    public class SVGContinuous : ASVGDrawer
    {

        public override void DrawLastPoint(ICurve C)
        {
            IPoint end = C.GetPoint(1);
            content.Append("<circle cx=\"" + (int)end.X + "\" cy=\"" + (int)end.Y + "\" r=\"3\" fill=\"green\" /> \n");
        }

        public override void DrawSegment(ICurve C, double t1, double t2)
        {
            IPoint start = C.GetPoint(t1);
            IPoint end = C.GetPoint(t2);

            content.Append("<line x1=\"" + (int)start.X + "\" y1=\"" + (int)start.Y + "\" x2=\"" + (int)end.X + "\" y2=\"" + (int)end.Y + "\" stroke=\"green\" stroke-dasharray=\"5,5\" /> \n");
        }

        public override void DrawFirstPoint(ICurve C)
        {
            IPoint start = C.GetPoint(0);
            content.Append("<rect x=\"" + (int)start.X + "\" y=\"" + (int)start.Y + "\" width=\"3\" height=\"3\" stroke=\"green\" fill=\"green\" /> \n");
        }
    }
}