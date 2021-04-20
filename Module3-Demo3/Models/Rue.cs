using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_Demo3.Models
{
    public class Rue
    {
        public string Nom { get; set; }
        public int Numero { get; set; }

        public override string ToString()
        {
            return $"Nom {this.Nom}, Numero = {this.Numero}";
        }
    }
}
