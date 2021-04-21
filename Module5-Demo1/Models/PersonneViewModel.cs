using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module5_Demo1.Models
{
    public class PersonneViewModel
    {
        public int? Id { get; set; }
        public int? Age { get; set; }

        public Personne Personne { get; set; }
    }
}