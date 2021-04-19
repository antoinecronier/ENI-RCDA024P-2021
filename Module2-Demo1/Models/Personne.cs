using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Demo1.Models
{
    public class Personne
    {
        private string nom;

        public string Nom { get => nom; set => nom = value; }

        //prop
        public string Prenom { get; set; }

        //propfull
        private int age;

        public int Age
        {
            get { return age; }
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Value below 0");
                }
                age = value; 
            }
        }

        //ctor
        public Personne()
        {

        }

        public Personne(string nom, string prenom) : this()
        {
            this.nom = nom;
            Prenom = prenom;
        }

        public Personne(string nom, string prenom, int age) : this(nom, prenom)
        {
            this.age = age;
        }
    }
}
