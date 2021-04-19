using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo3.Models
{
    public class Conserve : Aliment
    {
        public override void Conserver()
        {
            this.RangerDansLePlacard();
        }

        private void RangerDansLePlacard()
        {
            Console.WriteLine("Dans le placard");
        }
    }
}
