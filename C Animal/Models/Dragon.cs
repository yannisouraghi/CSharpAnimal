using C_Animal.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Animal.Models
{
    public class Dragon : Animal, IPilotage, IFly
    {
        public Dragon(string nom, rarity rarity , int ident) : base(nom, rarity, ident)
        {
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public override void Moove()
        {
            Console.WriteLine("Dragon is moving");
        }
        public new void Sleep()
        {
            Console.WriteLine("Dragon is sleeping");
        }

        public void Voler()
        {
            Console.WriteLine("Dragon est en train de voler");   
        }

    }
}
