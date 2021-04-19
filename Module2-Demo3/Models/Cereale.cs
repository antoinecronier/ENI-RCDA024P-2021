using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo3.Models
{
    public class Cereale : Aliment
    {
        public override void Conserver()
        {
            throw new NotImplementedException();
        }

        public new void Fermer()
        {
            Console.WriteLine("Fermer la boite");
        }

        public new void Ouvrir()
        {
            Console.WriteLine("Ourvrir la boite");
        }
    }
}
