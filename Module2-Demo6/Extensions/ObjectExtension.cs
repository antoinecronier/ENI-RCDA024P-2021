using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo6.Extensions
{
    public static class ObjectExtension
    {
        public static void ShowMethods(this Object item)
        {
            foreach (var methodInfo in item.GetType().GetMethods())
            {
                Console.WriteLine(methodInfo.Name);
            }
        }
    }
}
