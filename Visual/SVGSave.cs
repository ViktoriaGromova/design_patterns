using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometry;

namespace Visual
{

    class SVGSaver
    {
        protected List<ICurve> lines;
        private const int n = 25;

        public SVGSaver(List<VisualCurve> lines_)
        {
            //this.lines = new List<VisualCurve>();

            foreach (var curve in lines_)
            {
                this.lines.Add(curve.GetCurve());
            }
        }

        public void save(ASVGDrawer svgDrawer, string file)
        {
            foreach (var line in lines)
            {
                svgDrawer.DrawFirstPoint(line);

                for (double i = 1; i < n; i++)
                {
                    svgDrawer.DrawSegment(line, i / n, (i + 1) / n);
                }
                svgDrawer.DrawLastPoint(line);
            }

            svgDrawer.GetContent().Append("</svg>");
            string path = Directory.GetCurrentDirectory();
            string filePath = path + file;

            File.WriteAllText(filePath, svgDrawer.GetContent().ToString());
        }
    }
}