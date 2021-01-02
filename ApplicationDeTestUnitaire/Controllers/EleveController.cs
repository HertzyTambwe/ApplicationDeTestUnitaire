using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplicationDeTestUnitaire.Models;

namespace ApplicationDeTestUnitaire.Controllers
{
    public class EleveController : Controller
    {
        IRepository rep = null;

        //Pour le tests
        public EleveController(IRepository _rep)
        {
            rep = _rep;
        }
        // GET: Eleve

        [HandleError]
        public ContentResult Index()
        {
            throw new Exception("J'ai cree une erreur !");
            //rep.Add(new Eleve
            //{
            //    EleveID = 1,
            //    Nom = "Tambwe",
            //    Prenom = "hertzy"
            //});
            return Content($"Le nombre d'eleves : {rep.GetAll().Count}");
        }
    }
}