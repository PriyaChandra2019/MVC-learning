using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OdeToFood.Web
{
    internal class AutofacWebApiDependencyResolver : IDependencyResolver
    {
        private object container;

        public AutofacWebApiDependencyResolver(object container)
        {
            this.container = container;
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}