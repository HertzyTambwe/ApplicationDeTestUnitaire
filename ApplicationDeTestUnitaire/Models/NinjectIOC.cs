using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace ApplicationDeTestUnitaire.Models
{
    public class NinjectIOC : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectIOC()
        {
            kernel = new StandardKernel(); 
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IRepository>().To<Repository>();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}