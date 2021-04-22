using Module5_Demo1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Module5_Demo1.ValidationAttributs
{
    public class MyValidationAttribut : ValidationAttribute
    {
        public string Data { get; set; }
        public int MyProperty { get; set; }

        public MyValidationAttribut()
        {
            this.Data = "A";
        }

        public MyValidationAttribut(string data)
        {
            this.Data = data;
        }

        //public override bool IsValid(object value)
        //{
        //    return base.IsValid(value);
        //}

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //validationContext.ObjectInstance as Personne
            //validationContext.ObjectType // Module5_Demo1.Models.Personne
            //validationContext.Items

            if ((value as string).StartsWith(this.Data))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult($"Ne commence pas par { this.Data }");
            
            //return base.IsValid(value, validationContext);
        }
    }
}