using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDeTestUnitaire.Models;

namespace UnitTestProject1
{
    public class RepositoryTest : IRepository
    {
        public RepositoryTest()
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
