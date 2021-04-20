using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_Demo2.Models
{
    public class Personne
    {
        public int Age { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }

        public override string ToString()
        {
            return $"age {this.Age}, nom {this.Nom}, prenom {this.Prenom}";
        }
    }
}
