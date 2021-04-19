using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Tp1.Models
{
    public abstract class Forme
    {
        public abstract double Aire { get; }
        public abstract double Perimetre { get; }

        protected String AirePerimetre()
        {
            return$@"Aire = { this.Aire}
Périmètre = { this.Perimetre}
";
        }
    }
}
