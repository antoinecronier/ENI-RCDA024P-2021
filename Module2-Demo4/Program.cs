using Module2_Demo4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Fourmi fourmi1 = new Fourmi();
            Fruit fruit1 = new Fruit() { DateCueilette = DateTime.Now.AddDays(-5) };
            Console.WriteLine($"La fourmi mange un fruit {Zoo.NourrirAnimal(fourmi1, fruit1)}");

            Fruit fruit2 = new Fruit() { DateCueilette = DateTime.Now.AddDays(-12) };
            Console.WriteLine($"La fourmi mange un fruit {Zoo.NourrirAnimal(fourmi1, fruit2)}");

            Pate pate1 = new Pate() { DatePeremption = DateTime.Now.AddDays(1) };
            Pate pate2 = new Pate() { DatePeremption = DateTime.Now.AddDays(-1) };

            //Console.WriteLine($"La fourmi mange un fruit {Zoo.NourrirAnimal(fourmi1, pate1)}");

            Chat chat1 = new Chat();

            Console.WriteLine($"Le chat mange de la paté {Zoo.NourrirAnimal(chat1, pate1)}");
            Console.WriteLine($"Le chat mange de la paté {Zoo.NourrirAnimal(chat1, pate2)}");

            GenericTest<Chat>.ListElements();

            Console.ReadLine();
        }
    }
}
