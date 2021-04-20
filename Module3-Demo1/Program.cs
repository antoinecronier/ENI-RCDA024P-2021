using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_Demo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var emptyList = new List<int>();
            var maListe = new List<int?>();
            for (int i = 0; i < 20; i++)
            {
                maListe.Add(i);
            }

            Console.WriteLine("--------- First ---------");

            var first = maListe.First();
            Console.WriteLine(first);

            var firstOther = maListe.First(x => x > 10);
            Console.WriteLine(firstOther);

            try
            {
                var firstEmpty = emptyList.First();
                Console.WriteLine(firstEmpty);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                var firstOther1 = maListe.First(x => x > 50);
                Console.WriteLine(firstOther1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("--------- FirstOrDefault ---------");

            var firstOrD = maListe.FirstOrDefault();
            Console.WriteLine(firstOrD);

            var firstOtherOrD = maListe.FirstOrDefault(x => x > 10);
            Console.WriteLine(firstOtherOrD);

            var firstEmptyOrD = emptyList.FirstOrDefault();
            Console.WriteLine(firstEmptyOrD);

            var firstOther1OrD = maListe.FirstOrDefault(x => x > 50);
            Console.WriteLine(firstOther1OrD);

            Console.WriteLine("--------- Single ---------");
            maListe.Add(10);

            try
            {
                var single = maListe.Single();
                Console.WriteLine(single);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            emptyList.Add(1);
            var single1 = emptyList.Single();
            Console.WriteLine(single1);
            emptyList.Clear();

            try
            {
                var firstsingle = maListe.Single(x => x == 10);
                Console.WriteLine(firstsingle);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var firstsingle1 = maListe.Single(x => x == 1);
            Console.WriteLine(firstsingle1);

            Console.WriteLine("--------- Last ---------");

            var lastOrD = maListe.LastOrDefault();
            Console.WriteLine(lastOrD);

            var lastOtherOrD = maListe.LastOrDefault(x => x > 10);
            Console.WriteLine(lastOtherOrD);

            var lastEmptyOrD = emptyList.LastOrDefault();
            Console.WriteLine(lastEmptyOrD);

            var lastOther1OrD = maListe.LastOrDefault(x => x > 50);
            Console.WriteLine(lastOther1OrD);

            Console.ReadLine();
        }
    }
}
