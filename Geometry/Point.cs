using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Point : IPoint
    {
        private double x;
        private double y;

        public Point() : this(0, 0) { }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X {
            get {
                return x;
            }
            set {
                x = value;
            }
        }

        public double Y {
            get {
                return y;
            }
            set {
                y = value;
            }
        }
    }
}