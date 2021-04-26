using Module6_Demo2.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Demo2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                if (!(db.Personnes.Count() > 0))
                {
                    for (int i = 0; i < 20; i++)
                    {
                        db.Personnes.Add(new Entities.Personne() { Nom = "N" + i, Prenom = "P" + i });
                    }
                }

                if (!(db.Adresses.Count() > 0))
                {
                    for (int i = 0; i < 8; i++)
                    {
                        db.Adresses.Add(new Entities.Adresse() { Nom = "adresse" + i, Numero = i });
                    }
                }
                db.SaveChanges();
            }

            using (var db = new MyDbContext())
            {
                db.Personnes.FirstOrDefault(x => x.Id == 1).Adresse = db.Adresses.FirstOrDefault(x => x.Id == 1);
                db.Personnes.FirstOrDefault(x => x.Id == 2).Adresse = db.Adresses.FirstOrDefault(x => x.Id == 2);

                db.SaveChanges();
            }

            using (var db = new MyDbContext())
            {
                var personnes = db.Personnes.Where(x => x.Id < 3).ToList();
                foreach (var item in personnes)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }
    }
}
