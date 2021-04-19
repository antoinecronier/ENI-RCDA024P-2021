using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo4.Models
{
    public class Chat : Animal<Pate>
    {
        public bool SeNourrir(Pate aliment)
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
