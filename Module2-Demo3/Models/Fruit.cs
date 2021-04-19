using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo3.Models
{
    public class Fruit : Aliment
    {
        public override void Conserver()
        {
            this.RangerDansLeFrigo();
        }

        public override void Fermer()
        {
            base.Fermer();
            Console.WriteLine("Dans le papier");
        }

        public override void Ouvrir()
        {
            base.Ouvrir();
            Console.WriteLine("Dans le papier");
        }

        private void RangerDansLeFrigo()
        {
            Console.WriteLine("Dans le frigo");
        }
    }
}
