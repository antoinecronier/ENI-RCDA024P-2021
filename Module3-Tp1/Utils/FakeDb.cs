using Module3_Tp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_Tp1.Utils
{
    public class FakeDb
    {
        private static readonly Lazy<FakeDb> lazy = new Lazy<FakeDb>(() => new FakeDb());

        public static FakeDb Instance { get { return lazy.Value; } }

        private FakeDb()
        {
            this.InitialiserDatas();
        }

        public List<Auteur> Auteurs { get; } = new List<Auteur>();
        public List<Livre> Livres { get; } = new List<Livre>();

        private void InitialiserDatas()
        {
            Auteurs.Add(new Auteur("GROUSSARD", "Thierry"));
            Auteurs.Add(new Auteur("GABILLAUD", "Jérôme"));
            Auteurs.Add(new Auteur("HUGON", "Jérôme"));
            Auteurs.Add(new Auteur("ALESSANDRI", "Olivier"));
            Auteurs.Add(new Auteur("de QUAJOUX", "Benoit"));
            Livres.Add(new Livre(1, "C# 4", "Les fondamentaux du langage", Auteurs.ElementAt(0), 533));
            Livres.Add(new Livre(2, "VB.NET", "Les fondamentaux du langage", Auteurs.ElementAt(0), 539));
            Livres.Add(new Livre(3, "SQL Server 2008", "SQL, Transact SQL", Auteurs.ElementAt(1), 311));
            Livres.Add(new Livre(4, "ASP.NET 4.0 et C#", "Sous visual studio 2010", Auteurs.ElementAt(3), 544));
            Livres.Add(new Livre(5, "C# 4", "Développez des applications windows avec visual studio 2010", Auteurs.ElementAt(2), 452));
            Livres.Add(new Livre(6, "Java 7", "les fondamentaux du langage", Auteurs.ElementAt(0), 416));
            Livres.Add(new Livre(7, "SQL et Algèbre relationnelle", "Notions de base", Auteurs.ElementAt(1), 216));
            //TODO: DELETE
            //Livres.Add(new Livre(8, "SQL Server 2008", "SQL, Transact SQL", Auteurs.ElementAt(1), 311));

            Auteurs.ElementAt(0).addFacture(new Facture(3500, Auteurs.ElementAt(0)));
            Auteurs.ElementAt(0).addFacture(new Facture(3200, Auteurs.ElementAt(0)));
            Auteurs.ElementAt(1).addFacture(new Facture(4000, Auteurs.ElementAt(1)));
            Auteurs.ElementAt(2).addFacture(new Facture(4200, Auteurs.ElementAt(2)));
            Auteurs.ElementAt(3).addFacture(new Facture(3700, Auteurs.ElementAt(3)));
        }
    }
}
