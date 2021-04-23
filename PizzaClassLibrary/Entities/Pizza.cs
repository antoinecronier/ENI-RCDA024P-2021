using PizzaClassLibrary.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaClassLibrary.Entities
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5)]
        //[UniqueName]
        public string Nom { get; set; }
        [Required]
        public Pate Pate { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}
