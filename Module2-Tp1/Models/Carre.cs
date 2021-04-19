using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Tp1.Models
{
    public class Carre : Rectangle
    {
        public override int Largeur { get => this.Longueur; }

        public override string ToString()
        {
            return $@"Carré de côté {Largeur}
{this.AirePerimetre()}";
        }
    }
}
