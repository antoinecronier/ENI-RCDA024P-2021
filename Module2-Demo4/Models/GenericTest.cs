using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo4.Models
{
    public static class GenericTest<T> where T : class, new()
    {
        public static void ListElements()
        {
            T item = new T();
            foreach (var methodInfo in item.GetType().GetMethods())
            {
                Console.WriteLine(methodInfo.Name);

                if (item is Chat)
                {
                    if (methodInfo.Name.Equals("SeNourrir"))
                    {
                       Console.WriteLine($"Generic chat pate { methodInfo.Invoke(item, new Object[] { new Pate() { DatePeremption = DateTime.Now.AddDays(-1) } })} ");
                    }
                }
                
            }
        }
    }
}
