using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Demo5.Entities
{
    public class Personne
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public List<Personne> Enfants { get; set; } = new List<Personne>();

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
