using Module2_Demo3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cereale c1 = new Cereale();
            c1.Ouvrir();

            (c1 as Aliment).Ouvrir();


            Console.ReadLine();
        }
    }
}
