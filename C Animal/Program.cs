using C_Animal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Animal
{
    class Program
    {
            static void Main(string[] args)
            {

                Griffin Samy = new Griffin();
                Samy.Sleep();
                Samy.Moove();

                Dragon Joe = new Dragon();
                Joe.Sleep();
                Joe.Moove();
                
                

                Console.ReadLine();

            }
        
    }
}
