using PizzaClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaClassLibrary.Utils
{
    public class FakeDb
    {
        private static readonly Lazy<FakeDb> lazy = new Lazy<FakeDb>(() => new FakeDb());

        public static FakeDb Instance { get { return lazy.Value; } }

        private FakeDb()
        {
            this.InitialiserDatas();
        }

        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public List<Ingredient> Ingredients { get; set; }

        public List<Pate> Pates { get; set; }

        private void InitialiserDatas()
        {
            Ingredients = new List<Ingredient>
            {
                new Ingredient{Id=1,Nom="Mozzarella"},
                new Ingredient{Id=2,Nom="Jambon"},
                new Ingredient{Id=3,Nom="Tomate"},
                new Ingredient{Id=4,Nom="Oignon"},
                new Ingredient{Id=5,Nom="Cheddar"},
                new Ingredient{Id=6,Nom="Saumon"},
                new Ingredient{Id=7,Nom="Champignon"},
                new Ingredient{Id=8,Nom="Poulet"}
            };

            Pates = new List<Pate>
            {
                new Pate{ Id=1,Nom="Pate fine, base crême"},
                new Pate{ Id=2,Nom="Pate fine, base tomate"},
                new Pate{ Id=3,Nom="Pate épaisse, base crême"},
                new Pate{ Id=4,Nom="Pate épaisse, base tomate"}
            };

            Pizzas = new List<Pizza>
            {
                new Pizza{ Id=1, Nom="Pizza 1", Pate = Pates.ElementAt(1), Ingredients = new List<Ingredient>
                {
                    Ingredients.ElementAt(0),
                    Ingredients.ElementAt(1),
                    Ingredients.ElementAt(4),
                } },
                new Pizza{ Id=2, Nom="Pizza 2", Pate = Pates.ElementAt(3), Ingredients = new List<Ingredient>
                {
                    Ingredients.ElementAt(5),
                    Ingredients.ElementAt(2),
                    Ingredients.ElementAt(4),
                } }
            };
        }
    }
}
