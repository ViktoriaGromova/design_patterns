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
using System.DirectoryServices.ActiveDirectory;
using System.Security.Cryptography.X509Certificates;

namespace WF;

public partial class Form1 : Form
{
    Graphics g;
    int countoflines = 0;
    List<VisualCurve> lines;

    public Form1()
    {
        InitializeComponent();
        lines = new List<VisualCurve>();
    }

    private void HReflection_checkbox_CheckedChanged(object sender, EventArgs e)
    {
        Reflection();
        panel1.Refresh();
        panel2.Refresh();
    }
    private void VReflection_checkbox_CheckedChanged(object sender, EventArgs e)
    {
        Reflection();
        panel1.Refresh();
        panel2.Refresh();
    }

    private void Reflection()
    {
        while (lines.Count != countoflines)
        {
            lines.RemoveAt(lines.Count - 1);
        }

        if ((HReflection_checkbox.Checked || VReflection_checkbox.Checked))
        {
            for (int i = 0; i < countoflines; ++i)
            {
                if (HReflection_checkbox.Checked & VReflection_checkbox.Checked)
                {
                    lines.Add(new VisualCurve(new VerticalReflection(new HorizontalReflection(lines[i], panel1.Width), panel1.Height)));
                }
                else if (VReflection_checkbox.Checked)
                {
                    lines.Add(new VisualCurve(new VerticalReflection(lines[i], panel1.Height)));
                }
                else
                {
                    lines.Add(new VisualCurve(new HorizontalReflection(lines[i], panel1.Width)));
                }
            }
        }
    }
    private void Generate_button_Click(object sender, EventArgs e)
    {
        Random random = new Random();
        Func<int, int, IPoint> createRandomPoint = (min, max) => new Geometry.Point((float)random.Next(min, max), (float)random.Next(min, max));

        IPoint a1 = createRandomPoint(200, 500);
        IPoint b1 = createRandomPoint(200, 500);
        IPoint a = createRandomPoint(200, 500);
        IPoint b = createRandomPoint(200, 500);
        IPoint c = createRandomPoint(200, 500);
        IPoint d = createRandomPoint(200, 500);

        while (lines.Count != countoflines)
        {
            lines.RemoveAt(lines.Count - 1);
        }

        ICurve line = new Line(a1, b1);
        ICurve bezier = new Bezier(a, b, c, d);

        lines.Add(new VisualCurve(line));
        lines.Add(new VisualCurve(bezier));

        countoflines += 2;
        Reflection();
        panel1.Refresh();
        panel2.Refresh();
    }

    private void Clear_button_Click(object sender, EventArgs e)
    {
        if (lines.Count == 0) return;
        countoflines = 0;
        lines.Clear();
        panel1.Refresh();
        panel2.Refresh();
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {
        if (lines.Count == 0) return;

        IDrawer DottedDraw = new DottedDrawer(e.Graphics);

        for (int i = 0; i < lines.Count; ++i)
        {
            lines[i].Draw(DottedDraw);
        }
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
        if (lines.Count == 0) return;

        IDrawer ContinuousDraw = new ContinuousDrawer(e.Graphics);

        for (int i = 0; i < lines.Count; ++i)
        {
            lines[i].Draw(ContinuousDraw);
        }
    }

    private void ContinuousSave()
    {
        SVGContinuous svgContinuousDrawer = new SVGContinuous();

        foreach (var line in lines)
        {
            line.Draw(svgContinuousDrawer);
        }

        string path = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(path, "ContinuousLines.svg");
        File.WriteAllText(filePath, svgContinuousDrawer.GetContent().ToString() + "</svg>");
    }

    private void DottedSave()
    {
        SVGDotted svgDrawerDotted = new SVGDotted();

        foreach (var line in lines)
        {
            line.Draw(svgDrawerDotted);
        }

        string path = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(path, "DottedLines.svg");
        File.WriteAllText(filePath, svgDrawerDotted.GetContent().ToString() + "</svg>");
    }

    private void Save_Button_Clicked(object sender, EventArgs e)
    {
        ContinuousSave();
        DottedSave();
    }
}