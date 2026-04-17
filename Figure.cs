using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1261
{
    internal abstract class Figure
    {

        protected string name;

        public string Name { get { return name; } }

        public Figure(string name)
        {
            this.name = name;
        }

        public abstract float GetArea();
    }
}
