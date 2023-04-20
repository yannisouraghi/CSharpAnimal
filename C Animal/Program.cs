using C_Animal.Models;
using C_Animal.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Animal
{ 
    class Program
    {
        static void Main()
        {

            Griffin Samy = new Griffin("Sam", rarity.Common, 6);
            Samy.Sleep();
            Samy.Moove();
            Samy.Voler();

            Dragon Joe = new Dragon("Math", rarity.Legendaire, 7);
            Joe.Sleep();
            Joe.Moove();
            Joe.Voler();

            Vehicle Lambo = new Vehicle("Lambo");
            Lambo.Moove();

            //var dogs = new List<string> { "Math", "Sam", "Marius", "Snow", "Bibille" };

            //IEnumerable<string> filteringQuery =
            //            from dog in dogs
            //            where dog != "Snow"
            //            select dog;

            //filteringQuery.ToList().ForEach(dog => Console.WriteLine(dog + "\n"));
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ \n");
            //Animal[] animaux = new Animal[5]
            //            {
            //    new Dragon("Sam", rarity.Common,1),
            //    new Dragon("Samy",rarity.Rare,2),
            //    new Griffin("Marius", rarity.Common,3),
            //    new Griffin("Math", rarity.Rare,4),
            //    new Griffin("Molo", rarity.Legendaire,5)
            //            };

            //animaux.Where(l => l.rarity == rarity.Rare).ToList().ForEach(l => Console.WriteLine(l.id + ": " + l.Name+ "\n"));

            //var queryAnimal = from l in animaux
            //        where l.rarity == rarity.Common
            //        orderby l.id descending
            //        select l.Name ;
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ \n");
            //queryAnimal.ToList().ForEach(l => Console.WriteLine(l + "\n"));


            Console.ReadLine();

            }
        
    }
}
