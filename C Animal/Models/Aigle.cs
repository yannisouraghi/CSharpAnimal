using C_Animal.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Animal.Models
{
    class Aigle : Animal
    {
        public Aigle(string nom, rarity rarity, int ident) : base(nom, rarity, ident)
        {
        }

        public override void Moove()
        {
            Console.WriteLine("Aigle is moving");
        }
        public new void Sleep()
        {
            Console.WriteLine("Aigle is sleeping");
        }
    }
}
