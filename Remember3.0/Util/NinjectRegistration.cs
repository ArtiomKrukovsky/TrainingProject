using Ninject.Modules;
using Remember3._0.Domain.Interfaces;
using Remember3._0.Domain.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Remember3._0.Util
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}