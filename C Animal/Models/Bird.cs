using C_Animal.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Animal.Models
{
    class Bird : Animal
    {
        public Bird(string nom, rarity rarity, int ident) : base(nom, rarity, ident)
        {
        }

        public override void Moove()
        {
            Console.WriteLine("Bird is moving");
        }
        public new void Sleep()
        {
            Console.WriteLine("Bird is sleeping");
        }
    }
}
