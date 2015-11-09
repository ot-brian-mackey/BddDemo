using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BddDemo.Lib;
using Ninject;

namespace BddDemo
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            

            SetupDependencyInjection();
            //GlobalConfiguration.Configuration.DependencyResolver = new StructureMapDependencyResolver();
        }

        private void SetupDependencyInjection()
        {
            //create Ninject DI Kernel
            IKernel kernel = new StandardKernel();

            //tell asp.net mvc to use our Ninject DI Container
            GlobalConfiguration.Configuration.DependencyResolver = new NinjectResolver(kernel);

            //register services with Ninject DI container
            RegisterServices(kernel);
        }

        private void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IPayment>().To<Payment>();
            kernel.Bind<IVendor>().To<VendorXyz>();
        }
    }
}
