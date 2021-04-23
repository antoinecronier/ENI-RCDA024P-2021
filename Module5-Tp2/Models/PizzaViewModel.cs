using Module5_Tp2.ValidationAttributes;
using PizzaClassLibrary.Entities;
using PizzaClassLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module5_Tp2.Models
{
    public class PizzaViewModel
    {
        public Pizza Pizza { get; set; }
        public List<Pate> Pates { get; set; }
        public List<SelectListItem> Ingredients { get; set; }

        [ListRange(Max = 5, Min = 2)]
        public List<int> IngredientIds { get; set; }
    }
}