using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using Remember3._0.Domain.Models;
using Remember3._0.Util;
using Ninject.Modules;
using Ninject;
using Ninject.Web.Mvc;

namespace Remember3._0
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new Init());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //внедрение зависимости
            NinjectModule registration = new NinjectRegistration();
            var kernal = new StandardKernel(registration);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernal));
        }
    }
}
