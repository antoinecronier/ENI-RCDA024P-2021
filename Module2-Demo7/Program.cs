using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<DateTime, int> jourAvantNoel = new Func<DateTime, int>((date) =>
            {
                return (new DateTime(date.Year, 12, 25) - date).Days;
            });

            var nbJours = jourAvantNoel(DateTime.Now);
            Console.WriteLine(nbJours);

            Action<DateTime> jourAvantNoel1 = new Action<DateTime>((date) =>
            {
                Console.WriteLine($"{ (new DateTime(date.Year, 12, 25) - date).Days } jours avant noel");
            });

            jourAvantNoel1(DateTime.Now);
            Action<DateTime> jourAvantNoel2 = JourAvantNoel1;
            Func<DateTime, int> jourAvantNoel3 = JourAvantNoel;

            Console.ReadLine();
        }

        public static int JourAvantNoel(DateTime date)
        {
            return (new DateTime(date.Year, 12, 25) - date).Days;
        }
        public static void JourAvantNoel1(DateTime date)
        {
            Console.WriteLine($"{ (new DateTime(date.Year, 12, 25) - date).Days } jours avant noel");
        }
    }
}
