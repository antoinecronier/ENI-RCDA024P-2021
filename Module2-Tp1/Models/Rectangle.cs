using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Tp1.Models
{
    public class Rectangle : Forme
    {
        public virtual int Largeur { get; set; }
        public int Longueur { get; set; }

        public override double Aire => Largeur * Longueur;

        //public override double Perimetre => 2 * Largeur + 2 * Longueur;
        public override double Perimetre
        {
            get { return 2 * Largeur + 2 * Longueur; }
        }

        public override string ToString()
        {
            return $@"Rectangle de longueur={this.Longueur} at de largeur={this.Largeur}
{this.AirePerimetre()}";
        }
    }
}
