using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Animal.Models
{
    class Vehicle
    {
        public string marque;

        public Vehicle(string nom)
        {
            marque = nom;
        }

        public void Move()
        {
            Console.WriteLine(marque + "is moving");
        }
    }
}
