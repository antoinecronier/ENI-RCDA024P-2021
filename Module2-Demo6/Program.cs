using Module2_Demo6.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nb1 = 10;
            var nb2 = 5;

            Console.WriteLine($"{ nb1 } est il pair ? { nb1.EstPaire() }");
            Console.WriteLine($"{ nb2 } est il pair ? { nb2.EstPaire() }");

            var obj1 = new Object();
            obj1.ShowMethods();

            Console.ReadLine();
        }
    }
}
