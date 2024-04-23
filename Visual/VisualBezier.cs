// using Geometry;
// using System;
// using System.Collections.Generic;
// using System.Drawing;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Visual {
// 	public class VisualBezier : VisualCurve {

// 		private int quality = 100; // количество отрезков 

// 		public VisualBezier(Bezier curve) : base(curve) { }

// 		public VisualCurve SetQuality(int quality)
// 		{
// 			this.quality = quality;
// 			return this;
// 		}


// 		#region VisualCurve realization
// 		public override void Draw(Graphics g) {
// 			PointF[] points = Enumerable.Range(0, quality+1)
// 				.Select(p => (double)p / quality)
// 				.Select(p => GetPoint(p))
// 				.Select(p => new PointF((float)p.X, (float)p.Y)).ToArray();
// 			g.DrawLines(new Pen(color, width), points);
// 		}
// 		#endregion
// 	}
// }