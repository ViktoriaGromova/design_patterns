using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Visual
{
    public class Graphicsmy : IGraphics
    {
        Graphics g;
        Brush b;
        Pen p;

        public Graphicsmy(Graphics g, Pen p, Brush b)
        {
            this.g = g;
            this.p = p;
            this.b = b;
        }
        public void DrawEllipse(Pen p, int x, int y, int w, int h)
        {
            g.DrawEllipse(p, x - w, y - h, w * 2, h * 2);
        }
        public void DrawLine(Pen p, int x1, int y1, int x2, int y2)
        {
            g.DrawLine(p, x1, y1, x2, y2);
        }
    }
}