using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Visual
{
    public abstract class ASVGDrawer : IDrawer
    {
        protected StringBuilder content = new StringBuilder();
        public ASVGDrawer()
        {
             content.Append("<svg xmlns='http://www.w3.org/2000/svg' version='1.1'>");
        }
        public StringBuilder GetContent()
        {
            return this.content;
        }

        public abstract void DrawFirstPoint(ICurve C);
        public abstract void DrawLastPoint(ICurve C);
        public abstract void DrawSegment(ICurve C, double t1, double t2);

    }
}