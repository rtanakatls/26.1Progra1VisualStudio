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
        protected int age;

        public int Health
        {
            get { return health; } 
        }

        public int Age
        {
            get { return age; }
        }

        public Character(string name, int health, int age) : base(name)
        {
            this.health = health;
            this.age = age;
        }

    }
}
