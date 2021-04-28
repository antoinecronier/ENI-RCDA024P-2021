using System.Collections.Generic;
using System.ComponentModel;

namespace Module6_Tp1_BO.Entities
{
    public class Samourai : BaseEntity
    {
        public int Force { get; set; }
        public string Nom { get; set; }
        public virtual Arme Arme { get; set; }
        [DisplayName("Arts martiaux maitrisés")]
        public virtual List<ArtMartial> ArtMartiaux { get; set; }

        public int Potentiel { get { return (Force + (Arme != null ? Arme.Degats : 0)) * (ArtMartiaux.Count + 1); } }
    }
}
