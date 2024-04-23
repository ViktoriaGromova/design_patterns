using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Geometry;
using Visual;
using System.Threading;


namespace WF;

public partial class Form1 : Form
{
    Graphics g;
    bool generate_new;

    List<VisualCurve> lines;

    public Form1()
    {
        InitializeComponent();
        generate_new = false;
        lines = new List<VisualCurve>();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
        if (generate_new == true)
        {
            Random random = new Random();
            Func<int, int, IPoint> createRandomPoint = (min, max) => new Geometry.Point((float)random.Next(min, max), (float)random.Next(min, max));

            IPoint a = createRandomPoint(200, 500);
            IPoint b = createRandomPoint(200, 500);
            IPoint c = createRandomPoint(200, 500);
            IPoint d = createRandomPoint(200, 500);

            ICurve line = new Line(a, b);
            ICurve bezier = new Bezier(a, b, c, d);

            IDrawer DottedDraw = new DottedDrawer(e.Graphics);
            IDrawer ContinuousDraw = new ContinuousDrawer(e.Graphics);

            lines.Add(new VisualCurve(line));
            lines.Add(new VisualCurve(bezier));

            lines[0].Draw(DottedDraw);
            lines[1].Draw(ContinuousDraw);
            //generate_new = false;
        }

    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {
        if (generate_new == true)
        {
            Random random = new Random();
            Func<int, int, IPoint> createRandomPoint = (min, max) => new Geometry.Point((float)random.Next(min, max), (float)random.Next(min, max));

            IPoint a = createRandomPoint(200, 500);
            IPoint b = createRandomPoint(200, 500);
            IPoint c = createRandomPoint(200, 500);
            IPoint d = createRandomPoint(200, 500);

            ICurve line = new Line(a, b);
            ICurve bezier = new Bezier(a, b, c, d);

            IDrawer DottedDraw = new DottedDrawer(e.Graphics);
            IDrawer ContinuousDraw = new ContinuousDrawer(e.Graphics);

            lines.Add(new VisualCurve(line));
            lines.Add(new VisualCurve(bezier));

            lines[0].Draw(ContinuousDraw);
            lines[1].Draw(ContinuousDraw);
            //generate_new = false;
        }
    }

    private void Main_Form_Generate_Button_Clicked(object sender, EventArgs e)
        {
            generate_new = true;
            panel1.Refresh();
            panel2.Refresh();
        }


        private void Save_Button_Clicked(object sender, EventArgs e)
        {
            SaveToSVG();
        }

        private void SaveToSVG()
        {
            Visual.ASVGDrawer svgCont = new Visual.SVGContinuous();
            Visual.SVGSaver svgSaver = new Visual.SVGSaver(lines);
            svgSaver.save(svgCont, "//ContLines.svg"); 
}
}
