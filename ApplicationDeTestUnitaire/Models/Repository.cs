using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicationDeTestUnitaire.Models
{
    public class Repository : IRepository
    {
        public Repository()
        {
            eleves = new List<Eleve>();
        }
        private List<Eleve> eleves;

        public void Add(Eleve eleve)
        {
            eleves.Add(eleve);
        }

        public bool Delete(int id)
        {
            return eleves.Remove(eleves.Where(x => x.EleveID == id).FirstOrDefault());
        }

        public List<Eleve> GetAll()
        {
            return eleves;
        }
    }
}