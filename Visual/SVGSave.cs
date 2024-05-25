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
        protected List<VisualCurve> lines;
        private const int n = 25;

        public SVGSaver(List<VisualCurve> lines_)
        {
            this.lines = lines_;
        }
        public void save(string file)
        {
            StringBuilder svgContent = new StringBuilder();
            svgContent.Append("<svg xmlns='http://www.w3.org/2000/svg' version='1.1'>");
            ASVGDrawer svgDrawer;
            foreach (var line in lines)
            {

               if (line.GetTypeDrawer() == typeof(DottedDrawer))
                {
                    svgDrawer = new SVGDotted();
                }
                else
                {
                    svgDrawer = new SVGContinuous();
                }
                double t = (double)1 / n;

                svgDrawer.DrawFirstPoint(line.GetCurve());
                for (int i = 1; i <= n; ++i)
                {
                    svgDrawer.DrawSegment(line.GetCurve(), (double)(i - 1) * t, (double)(i * t));
                }
                svgDrawer.DrawLastPoint(line.GetCurve());
                svgContent.Append(svgDrawer.GetContent().ToString());
            }

            string path = Directory.GetCurrentDirectory();
            string filePath = path + file;

            File.WriteAllText(filePath, svgContent.ToString() + "</svg>");
        }
    }
}