using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo3.Models
{
    public abstract class Aliment : Emballage
    {
        public DateTime DatePeremption { get; set; }

        public bool EstPerime()
        {
            return DateTime.Now > this.DatePeremption;
        }

        public abstract void Conserver();

        public virtual void Ouvrir()
        {
            Console.WriteLine("Ouvrir l'élément");
        }

        public virtual void Fermer()
        {
            Console.WriteLine("Fermer l'élément");
        }
    }
}
