using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Module5_Tp2.ValidationAttributes
{
    public class ListRange : ValidationAttribute
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public override string FormatErrorMessage(string name)
        {
            return $"La liste doit comprendre entre {this.Min} et {this.Max} éléments";
        }

        public override bool IsValid(object value)
        {
            if (Max < Min)
            {
                throw new Exception("Min <= Max");
            }

            bool result = false;

            if (value is ICollection)
            {
                if ((value as ICollection).Count >= Min && (value as ICollection).Count <= Max)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}