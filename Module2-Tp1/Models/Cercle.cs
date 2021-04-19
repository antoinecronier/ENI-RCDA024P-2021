using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Tp1.Models
{
    public class Cercle : Forme
    {
        public int Rayon { get; internal set; }

        public override double Aire => Math.PI * Math.Pow(Rayon, 2);

        public override double Perimetre => 2 * Math.PI * Rayon;

        public override string ToString()
        {
            return $@"Cercle de rayon {this.Rayon}
{this.AirePerimetre()}";
        }
    }
}
