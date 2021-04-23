using PizzaClassLibrary.Entities;
using PizzaClassLibrary.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaClassLibrary.ValidationAttributes
{
    public class UniqueName : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var pizza = validationContext.ObjectInstance as Pizza;
            var nom = value as string;
            if (FakeDb.Instance.Pizzas.Any(x => x.Nom.Equals(nom) && pizza.Id != x.Id))
            {
                return new ValidationResult("Il existe déjà une pizza avec ce nom");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
