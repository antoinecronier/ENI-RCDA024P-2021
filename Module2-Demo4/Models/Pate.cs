using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo4.Models
{
    public class Pate : Nourriture
    {
        public DateTime DatePeremption { get; set; }

        public bool EstPerime()
        {
            return DatePeremption > DateTime.Now;
        }
    }
}
