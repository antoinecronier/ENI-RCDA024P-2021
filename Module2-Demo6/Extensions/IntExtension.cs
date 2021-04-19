using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo6.Extensions
{
    public static class IntExtension
    {
        public static bool EstPaire(this int nombre)
        {
            return nombre % 2 == 0;
        }
    }
}
