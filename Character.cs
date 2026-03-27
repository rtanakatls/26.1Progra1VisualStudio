using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1261
{
    internal class Character : Entity
    {
        protected int health;

        public int Health
        {
            get { return health; } 
        }

        public Character(string name, int health) : base(name)
        {
            this.health = health;
        }

    }
}
