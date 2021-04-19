using Module2_Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Personne p1 = new Personne();
            p1.Nom = "";
            p1.Prenom = "";
            p1.Age = 10;

            Personne p2 = new Personne("", "", 20);

            Personne p3 = new Personne() { Nom = "", Prenom = "", Age = 5 };

            Personne p4;

            p4 = p3;

            p4.Nom = "test";

            Console.WriteLine($"p3.Nom : {p3.Nom}, p4.Nom : {p4.Nom}");
            Console.ReadLine();
        }
    }
}
