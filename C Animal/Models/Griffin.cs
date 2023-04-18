using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Animal.Models
{
    public class Griffin : Animal
    {
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
