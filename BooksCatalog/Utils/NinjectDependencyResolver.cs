using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BooksCatalog.Infrastructure;
using Ninject;

namespace BooksCatalog.Utils
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            kernel.Bind<IMapper>().ToConstant(AutoMapperConfig.Config());
        }
    }
}