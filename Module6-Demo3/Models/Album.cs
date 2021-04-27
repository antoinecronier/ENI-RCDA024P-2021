using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module6_Demo3.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Groupe { get; set; }
        public int Annee { get; set; }
        public int NombreDePiste { get; set; }
        public List<Piste> Pistes { get; set; }
        public List<Artiste> Artistes { get; set; }
    }
}