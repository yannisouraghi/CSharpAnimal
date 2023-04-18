using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Animal.Models
{
    public class Dragon : Animal
    {
        public override void Moove()
        {
            Console.WriteLine("Dragon is moving");
        }
        public new void Sleep()
        {
            Console.WriteLine("Dragon is sleeping");
        }
    }
}
