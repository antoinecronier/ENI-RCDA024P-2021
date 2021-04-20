using Module3_Demo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_Demo2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var personnes = new List<Personne>()
            {
                new Personne(){ Age = 15, Prenom = "p1", Nom = "n1"},
                new Personne(){ Age = 24, Prenom = "toto", Nom = "tata"},
                new Personne(){ Age = 32, Prenom = "toto", Nom = "n1"},
                new Personne(){ Age = 40, Prenom = "p1", Nom = "toto"},
                new Personne(){ Age = 15, Prenom = "test", Nom = "test"},
                new Personne(){ Age = 20, Prenom = "bonjour", Nom = "n1"}
            };

            Console.WriteLine("------- Where -------");
            var subPs1 = personnes.Where(x => x.Age < 30);
            foreach (var item in subPs1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------- Distinct -------");
            var subPs2 = personnes.Select(x => x.Age).Distinct();
            foreach (var item in subPs2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------- Take -------");
            var subPs3 = personnes.Take(3);
            foreach (var item in subPs3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------");

            var subPs4 = personnes.Take(30);
            foreach (var item in subPs4)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
