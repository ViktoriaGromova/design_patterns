using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
public abstract class ACurve : ICurve
    {
        protected IPoint a, b;

        public ACurve(IPoint a, IPoint b)
        {
            this.a = a;
            this.b = b;
        }

        public abstract IPoint GetPoint(double t);
    }
}