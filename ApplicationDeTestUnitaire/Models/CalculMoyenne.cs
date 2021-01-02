using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicationDeTestUnitaire.Models
{
    public class CalculMoyenne : ICalculMoyenne
    {
        public double CalculMoyenneEleve(Eleve eleve)
        {
            return eleve.Notes.Sum() / eleve.Notes.Count;
        }

        public double CalculMoyenneClass(List<Eleve> eleves)
        {
            return eleves.Select(s => s.Notes).Sum(x => x.Sum()) / eleves.Select(s => s.Notes).Count();
        }
    }
}