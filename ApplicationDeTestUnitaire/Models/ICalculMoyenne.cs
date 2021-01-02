using System.Collections.Generic;

namespace ApplicationDeTestUnitaire.Models
{
    public interface ICalculMoyenne
    {
        double CalculMoyenneClass(List<Eleve> eleves);
        double CalculMoyenneEleve(Eleve eleve);
    }
}