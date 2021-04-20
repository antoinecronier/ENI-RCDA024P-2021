using Module3_Tp1.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_Tp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Afficher la liste des prénoms des auteurs dont le nom commence par "G"
            var q1 = FakeDb.Instance.Auteurs.Where(x => x.Nom.StartsWith("G")).Select(x => x.Prenom);
            Console.WriteLine("Q1");
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

            //Afficher l’auteur ayant écrit le plus de livres
            IGrouping<Models.Auteur, Models.Livre>  q2 = FakeDb.Instance.Livres.GroupBy(x => x.Auteur).OrderByDescending(x => x.Count()).FirstOrDefault();
            Console.WriteLine("Q2");
            Console.WriteLine($"{q2.Key.Nom} {q2.Key.Prenom}");

            List<IGrouping<Models.Auteur, Models.Livre >> dataQ2 = 
                FakeDb.Instance.Livres.GroupBy(x => x.Auteur)
                .Where(x => x.Count() == 
                    FakeDb.Instance.Livres.GroupBy(y => y.Auteur)
                    .Max(y => y.Count()))
                .ToList();

            Console.WriteLine("Q2 - bis");
            foreach (var item in dataQ2)
            {
                Console.WriteLine($"{item.Key.Nom} {item.Key.Prenom}");
            }

            //Afficher le nombre moyen de pages par livre par auteur
            Console.WriteLine("Q3");
            FakeDb.Instance.Livres.GroupBy(x => x.Auteur).ToList().ForEach(x =>
            {
                Console.WriteLine($"{x.Key.Nom} {x.Key.Prenom}");
                Console.WriteLine($"Moyenne des pages {x.Average(y => y.NbPages)}");
            });

            //Afficher le titre du livre avec le plus de pages
            Console.WriteLine("Q4");
            var q4 = FakeDb.Instance.Livres.Where(x => x.NbPages == FakeDb.Instance.Livres.Max(y => y.NbPages));
            foreach (var item in q4)
            {
                Console.WriteLine($"{item.Titre}");
            }

            //Afficher combien ont gagné les auteurs en moyenne(moyenne des factures)
            Console.WriteLine("Q5");
            Console.WriteLine(FakeDb.Instance.Auteurs.Where(x => x.Factures.Count > 0).Average(x => x.Factures.Average(y => y.Montant)));

            //Afficher les auteurs et la liste de leurs livres
            Console.WriteLine("Q6");
            FakeDb.Instance.Livres.GroupBy(x => x.Auteur).ToList().ForEach((x) => 
            {
                Console.WriteLine($"{x.Key.Nom} {x.Key.Prenom}");
                x.ToList().ForEach((y) => 
                {
                    Console.WriteLine($"\t{y.Titre}");
                });
            });

            //Afficher les titres de tous les livres triés par ordre alphabétique
            Console.WriteLine("Q7");
            FakeDb.Instance.Livres.Select(x => x.Titre).OrderBy(x => x).ToList()
                .ForEach(Console.WriteLine);

            //Afficher la liste des livres dont le nombre de pages est supérieur à la moyenne
            Console.WriteLine("Q8");
            FakeDb.Instance.Livres.Where(x => x.NbPages >= FakeDb.Instance.Livres.Average(y => y.NbPages)).Select(x => x.Titre).ToList().ForEach(Console.WriteLine);

            //Afficher l'auteur ayant écrit le moins de livres
            Console.WriteLine("Q9");
            FakeDb.Instance.Livres.GroupBy(x => x.Auteur).Where(x => x.Count() == FakeDb.Instance.Livres.GroupBy(y => y.Auteur).Min(y => y.Count())).ToList().ForEach(x => 
            {
                Console.WriteLine($"{x.Key.Nom} {x.Key.Prenom}");
            });

            Console.ReadLine();
        }
    }
}
