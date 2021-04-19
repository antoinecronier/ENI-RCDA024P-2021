using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo4.Models
{
    public class Fourmi : Animal<Fruit>
    {
        public bool SeNourrir(Fruit aliment)
        {
            bool result = true;

            if (aliment.EstPerime())
            {
                result = false;
            }

            return result;
        }
    }
}
