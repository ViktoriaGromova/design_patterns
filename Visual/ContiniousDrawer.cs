using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks; 
using Geometry;

namespace Visual
{
 class ContinuousDrawer : ADrawerGraphics
    {
        private Pen pn;
        Brush br;
        public ContinuousDrawer(Graphics g) : base()
        {
            pn = new Pen(Color.Green, 2);
            pn.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.g = g;
            this.br = (Brush)Brushes.Green;
        }

        public override void DrawLastPoint(ICurve C)
        {
            IPoint p = C.GetPoint(1);
            g.FillEllipse(br, (float)p.X, (float)p.Y, 10, 10);
        }

        public override void DrawFirstPoint(ICurve C)
        {
            IPoint p = C.GetPoint(0);
            g.FillRectangle(br, (float)p.X, (float)p.Y, 5, 5);
        }

         public override void DrawSegment(ICurve C, double t1, double t2)
        {
            IPoint start = C.GetPoint(t1);
            IPoint end = C.GetPoint(t2);

            g.DrawLine(pn, (float)start.X, (float)start.Y, (float)end.X, (float)end.Y);
        
        }
    }
}