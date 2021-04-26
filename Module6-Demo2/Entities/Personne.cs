using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Demo2.Entities
{
    public class Personne
    {
        public long Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public virtual Adresse Adresse { get; set; }

        public override string ToString()
        {
            return $"Id {Id}, Prenom {Prenom}, Nom {Nom}, Adresse\n\tId {Adresse?.Id}\tNom {Adresse?.Nom}\tNumero {Adresse?.Numero}";
        }
    }
}
