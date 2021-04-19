using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo4.Models
{
    public class Zoo
    {
        public static bool NourrirAnimal<A, N>(A animal, N nourriture) where N : Nourriture where A: Animal<N>
        {
            return animal.SeNourrir(nourriture);
        }
    }
}
