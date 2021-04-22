using Module5_Demo1.ValidationAttributs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Module5_Demo1.Models
{
    public class Personne
    {
        public int Id { get; set; }

        [Required]
        //[Compare("Prenom")]
        //[Phone]
        //[RegularExpression("")]
        [MyValidationAttribut("B")]
        public string Nom { get; set; }

        [StringLength(20, MinimumLength = 5)]
        [EmailAddress] // a@a.a
        public string Prenom { get; set; }

        [Range(5, 105)]
        public int Age { get; set; }
    }
}