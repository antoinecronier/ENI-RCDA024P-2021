using Module3_Demo3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_Demo3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rues = new List<Rue>()
            {
                new Rue() { Nom="rue 20001", Numero=1},
                new Rue() { Nom="rue 2", Numero=10},
                new Rue() { Nom="rue 2", Numero=15},
                new Rue() { Nom="rue 160", Numero=23},
                new Rue() { Nom="rue 1", Numero=11},
                new Rue() { Nom="rue 4", Numero=14},
                new Rue() { Nom="rue 1", Numero=15},
                new Rue() { Nom="rue 5", Numero=13},
                new Rue() { Nom="rue 10", Numero=16},
                new Rue() { Nom="rue 11", Numero=41}
            };

            Console.WriteLine("------ OrderBy ------");
            var order1 = rues.OrderBy(x => x.Nom);

            foreach (var item in order1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------ OrderByDescending ------");
            var order2 = rues.OrderByDescending(x => x.Numero);

            foreach (var item in order2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------ ThenBy ------");
            var order3 = rues.OrderBy(x => x.Numero).ThenBy(x => x.Nom);

            foreach (var item in order3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------ Sort ------");
            rues.Sort(comparison: (x1, x2) => x1.Numero - x2.Numero);

            foreach (var item in rues)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------ All ------");
            Console.WriteLine($"Les numéros sont inférieurs à 50 y/n {rues.All(x => x.Numero < 50)}");
            Console.WriteLine($"Les numéros sont inférieurs à 20 y/n {rues.All(x => x.Numero < 20)}");

            Console.WriteLine("------ Any ------");
            Console.WriteLine($"Au moins un élément est plus grand que 40 y/n {rues.Any(x => x.Numero > 40)}");
            Console.WriteLine($"Au moins un élément est plus grand que 50 y/n {rues.All(x => x.Numero > 50)}");

            Console.WriteLine("------ Select ------");
            var test1 = rues.Select(x => (x.Numero * 2) + ":" + x.Nom.ToUpper());
            foreach (var item in test1)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
