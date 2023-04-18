using C_Animal.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Animal.Models
{
    public abstract class Animal
    {
        public string Name { get; protected set; }
        public rarity rarity;
        public int id;
        public virtual void Moove()
        {
            Console.WriteLine("Move");
        }
        public virtual void Sleep()
        {
            Console.WriteLine("Sleep");
        }

        public Animal()
        {
            Name = "Math";
            rarity = rarity.Common;
        }

        public Animal(string nom, rarity rarete, int ident)
        {
            id = ident;
            Name = nom;
            rarity = rarete;
        }
    }


}
