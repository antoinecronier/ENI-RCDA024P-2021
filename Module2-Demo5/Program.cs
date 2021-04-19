using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<int>();
            Console.WriteLine(list.Count);

            list.Add(47);
            list.Add(1);
            list.Add(23);
            list.Add(47);
            list.Add(47);
            list.Add(12);
            list.Add(-1);

            Console.WriteLine(list.Count);


            var list1 = new List<int>(10);
            Console.WriteLine(list1.Capacity);
            Console.WriteLine(list1.Count);

            for (int i = 0; i < 20; i++)
            {
                if (list1.Count + 1 <= list1.Capacity)
                {
                    list1.Add(i);
                }
            }
            Console.WriteLine(list1.Capacity);
            Console.WriteLine(list1.Count);

            if (list.Contains(47))
            {
                Console.WriteLine("La liste contient 47");
                list.Remove(47);
            }

            list.RemoveAll(x => x == 47);

            list.AddRange(new List<int>() { 10, 20, 50});

            StringBuilder builder = new StringBuilder();
            foreach (var item in list)
            {
                builder.Append(item);
            }
            Console.Write(builder.ToString());

            Console.ReadLine();
        }
    }
}
