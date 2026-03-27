using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1261
{
    internal class Menu
    {
        public void Execute()
        {
            string name;
            int age;

            Console.WriteLine("Hola, introduce tu nombre");
            name= Console.ReadLine();
            Console.WriteLine("Ingresa tu edad");
            age= int.Parse(Console.ReadLine());

            Character character = new Character(name, 100,age);
            Console.WriteLine($"Hola {character.Name} tienes {character.Health} de vida y tienes {age} años");
        }
    }
}
