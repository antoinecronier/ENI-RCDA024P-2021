using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Tp1.Models
{
    public class Triangle : Forme
    {
        public int A { get; internal set; }
        public int B { get; internal set; }
        public int C { get; internal set; }

        private double p => Perimetre / 2;

        public override double Aire => Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        public override double Perimetre => A + B + C;

        public override string ToString()
        {
            return $@"Triangle de cote A={this.A} B={this.B} C={this.C}
{this.AirePerimetre()}";
        }
    }
}
