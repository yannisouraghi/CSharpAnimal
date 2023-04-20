using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Animal.Models
{
    public class Vehicle : IPilotage
    {
        public string marque;

        public Vehicle(string nom)
        {
            marque = nom;
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Moove()
        {
            Console.WriteLine(marque + " is moving");
        }

        public void Voler()
        {
            throw new NotImplementedException();
        }
    }
}
