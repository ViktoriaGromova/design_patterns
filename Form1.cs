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
    IDrawer DottedDraw, ContinuousDraw;

    List<VisualCurve> lines;

    public Form1()
    {
        InitializeComponent();
        lines = new List<VisualCurve>();

    }

    private void HReflection_checkbox_CheckedChanged(object sender, EventArgs e)
    {
        panel1.Refresh();
    }

    private void VReflection_checkbox_CheckedChanged(object sender, EventArgs e)
    {
        panel1.Refresh();
    }

    private void Generate_button_Click(object sender, EventArgs e)
    {
        lines.Clear();
        Random random = new Random();
        Func<int, int, IPoint> createRandomPoint = (min, max) => new Geometry.Point((float)random.Next(min, max), (float)random.Next(min, max));

        IPoint a = createRandomPoint(200, 500);
        IPoint b = createRandomPoint(200, 500);
        IPoint c = createRandomPoint(200, 500);
        IPoint d = createRandomPoint(200, 500);

        ICurve line = new Line(a, b);
        ICurve bezier = new Bezier(a, b, c, d);

        lines.Add(new VisualCurve(line));
        lines.Add(new VisualCurve(bezier));

        //для отражения
        lines.Add(new VisualCurve(line));
        lines.Add(new VisualCurve(bezier));
        panel1.Refresh();
    }


    private void panel1_Paint(object sender, PaintEventArgs e)
    {
        if (lines.Count == 0) return;
        IDrawer DottedDraw = new DottedDrawer(e.Graphics);
        IDrawer ContinuousDraw = new ContinuousDrawer(e.Graphics);
        lines[0].Draw(DottedDraw);
        lines[1].Draw(ContinuousDraw);



        if (HReflection_checkbox.Checked || VReflection_checkbox.Checked)
        {
            if (HReflection_checkbox.Checked & VReflection_checkbox.Checked)
            {
                lines[2] = new VisualCurve(new VerticalReflection(new HorizontalReflection(lines[0], panel1.Width), panel1.Height));
                lines[3] = new VisualCurve(new VerticalReflection(new HorizontalReflection(lines[1], panel1.Width), panel1.Height));
               
            }
            else if (VReflection_checkbox.Checked)
            {
                lines[2] = new VisualCurve(new VerticalReflection(lines[0], panel1.Height));
                lines[3] = new VisualCurve(new VerticalReflection(lines[1], panel1.Height));
            }
            else
            {
                lines[2] = new VisualCurve(new HorizontalReflection(lines[0], panel1.Width));
                lines[3] = new VisualCurve(new HorizontalReflection(lines[1], panel1.Width));
            }
            lines[2].Draw(DottedDraw);
            lines[3].Draw(ContinuousDraw);
        }
    }

    private void Save_Button_Clicked(object sender, EventArgs e)
    {
        SaveToSVG(sender, e);
    }

    private void SaveToSVG(object sender, EventArgs e)
    {
        Visual.SVGSaver svgSaver = new Visual.SVGSaver(lines);
        // lines[2].Draw(svgSaver);
        // lines[2].Draw(svgSaver);
        svgSaver.save("//ContLines.svg");
    }
}