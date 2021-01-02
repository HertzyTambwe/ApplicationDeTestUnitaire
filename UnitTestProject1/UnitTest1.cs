using System;
using System.Collections.Generic;
using ApplicationDeTestUnitaire.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ninject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IRepository rep = null;

            IKernel kernel = new StandardKernel();
            kernel.Bind<IRepository>().To<RepositoryTest>();
            rep = kernel.Get<IRepository>();

            ApplicationDeTestUnitaire.Controllers.EleveController eleveController = new ApplicationDeTestUnitaire.Controllers.EleveController(rep);
            Assert.IsTrue(eleveController.Index().Content.Equals($"Le nombre d'eleves : 0"));
            List<double> notes = new List<double> { 11,12,14,10,15,9,5,15 };
            rep.Add(new Eleve
            {
                EleveID = 1,
                Nom = "Tambwe",
                Prenom = "Hertzy",
                Notes = notes
            });
            Assert.IsTrue(eleveController.Index().Content.Equals($"Le nombre d'eleves : 1"));

            CalculMoyenne calculM = new CalculMoyenne();
            var retour = calculM.CalculMoyenneEleve(rep.GetAll()[0]);
            Assert.AreEqual(11.375, retour);


            Mock<ICalculMoyenne> calMock = new Mock<ICalculMoyenne>();

            calMock.Setup(m => m.CalculMoyenneEleve(It.IsAny<Eleve>())).Returns(19);

            var result = calMock.Object.CalculMoyenneEleve(new Eleve());
            Assert.AreEqual(19, result);
         }
    }
}
