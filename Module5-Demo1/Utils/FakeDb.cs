using Module5_Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_Demo1.Utils
{
    public class FakeDb
    {
        private static readonly Lazy<FakeDb> lazy = new Lazy<FakeDb>(() => new FakeDb());

        public static FakeDb Instance { get { return lazy.Value; } }

        private FakeDb()
        {
            this.InitialiserDatas();
        }

        public List<Personne> Personnes { get; } = new List<Personne>();

        private void InitialiserDatas()
        {
            for (int i = 1; i < 50; i++)
            {
                Personnes.Add(new Personne() { Id = i, Nom = "n" + i, Prenom = "p" + i, Age = 3 * i % 40 });
            }
        }
    }
}
