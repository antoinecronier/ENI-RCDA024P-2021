using Module6_Demo5.Datas;
using Module6_Demo5.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Demo5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Init();
            Console.WriteLine("-------- Raw data no loading ------------");
            using (var db = new MyDbContext())
            {
                foreach (var item in db.Personnes)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("-------- Raw data explicit loading ------------");
            using (var db = new MyDbContext())
            {
                var parent = db.Personnes.Find(1);
                db.Entry(parent).Collection(p => p.Enfants).Load();
                Console.WriteLine(parent);
            }

            Console.WriteLine("-------- Raw data eager loading ------------");
            using (var db = new MyDbContext())
            {
                var parent = db.Personnes.Include(p => p.Enfants.Select(e => e.Enfants)).FirstOrDefault(x => x.Id == 1);
                Console.WriteLine(parent);
            }

            Console.WriteLine("-------- Raw data loop explicit loading ------------");
            using (var db = new MyDbContext())
            {
                var parent = db.Personnes.Find(1);

                LoadAll(parent, db);

                Console.WriteLine(parent);
            }


            Console.ReadLine();
        }

        private static void LoadAll(Personne parent, MyDbContext db)
        {
            db.Entry(parent).Collection(p => p.Enfants).Load();
            foreach (var item in parent.Enfants)
            {
                LoadAll(item, db);
            }
        }

        private static void Init()
        {
            using (var db = new MyDbContext())
            {
                var parent = new Personne() { Nom = "parentNom", Prenom = "parentPrenom" };
                var enfant1 = new Personne() { Nom = "enfant1Nom", Prenom = "enfant1Prenom" };
                var enfant2 = new Personne() { Nom = "enfant2Nom", Prenom = "enfant2Prenom" };
                var petitEnfant1 = new Personne() { Nom = "petitEnfant1Nom", Prenom = "petitEnfant1PreNom" };
                var petitEnfant2 = new Personne() { Nom = "petitEnfant2Nom", Prenom = "petitEnfant2PreNom" };
                var petitEnfant3 = new Personne() { Nom = "petitEnfant3Nom", Prenom = "petitEnfant3PreNom" };
                var petitEnfant4 = new Personne() { Nom = "petitEnfant4Nom", Prenom = "petitEnfant4PreNom" };

                parent.Enfants.Add(enfant1);
                parent.Enfants.Add(enfant2);

                enfant1.Enfants.Add(petitEnfant1);
                enfant2.Enfants.Add(petitEnfant2);
                enfant2.Enfants.Add(petitEnfant3);
                enfant2.Enfants.Add(petitEnfant4);

                db.Personnes.Add(parent);
                db.SaveChanges();
            }
        }
    }
}
