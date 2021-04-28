using Module6_Tp1_BO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module6_Tp1_ASP.Models
{
    public class SamouraiViewModel
    {
        public Samourai Samourai { get; set; }
        public List<Arme> Armes { get; set; }
        public List<ArtMartial> ArtMartiaux { get; set; }
        public int? ArmeId { get; set; }
        public List<int> ArtMartiauxIds { get; set; }
    }
}