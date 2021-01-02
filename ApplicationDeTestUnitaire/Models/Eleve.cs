using System.Collections.Generic;

namespace ApplicationDeTestUnitaire.Models
{
    public class Eleve
    {
        public int EleveID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public List<double> Notes { get; set; }

    }
}