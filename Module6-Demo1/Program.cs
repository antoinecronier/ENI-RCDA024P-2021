using Module6_Demo1.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Demo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                for (int i = 0; i < 20; i++)
                {
                    db.Personnes.Add(new Entities.Personne() { Nom = "N" + i, Prenom = "P" + i });
                }
                db.SaveChanges();
            }

            Console.ReadLine();
        }
    }
}
