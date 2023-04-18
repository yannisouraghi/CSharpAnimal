using C_Animal.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Animal.Models
{
    public class Griffin : Animal
    {
        private string v1;
        private rarity common;
        private int v2;

        public Griffin(string nom, rarity rarity, int ident) : base(nom, rarity, ident)
        {
        }

        public override void Moove()
        {
            Console.WriteLine("Griffin is moving");
        }
        public new void Sleep()
        {
            Console.WriteLine("Griffin is sleeping");
        }
    }
}
