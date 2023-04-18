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
        }

        public Animal(string Name)
        {
            Name = "Math";
        }
    }


}
