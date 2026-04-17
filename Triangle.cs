using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1261
{
    internal class Triangle : Figure
    {
        protected float b;
        protected float h;

        public Triangle(string name, float b, float h) : base(name)
        {
            this.b = b;
            this.h = h;
        }

        public override float GetArea()
        {
            return (b * h) / 2;
        }
    }
}
