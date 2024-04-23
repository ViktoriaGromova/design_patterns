using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Visual
{
    public interface IGraphics
    {
        void DrawEllipse(Pen p, int x, int y, int w, int h);
        void DrawLine(Pen p, int x1, int y1, int x2, int y2);
    }
}
