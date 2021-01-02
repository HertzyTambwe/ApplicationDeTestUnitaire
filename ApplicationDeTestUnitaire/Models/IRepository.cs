using System.Collections.Generic;

namespace ApplicationDeTestUnitaire.Models
{
    public interface IRepository
    {
        void Add(Eleve eleve);
        bool Delete(int id);
        List<Eleve> GetAll();
    }
}