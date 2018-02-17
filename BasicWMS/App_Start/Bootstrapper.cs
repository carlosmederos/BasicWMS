using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using BasicWMS.Controllers;
using BasicWMS.Data;
using BasicWMS.AutoMapper;
using BasicWMS.Data.Infrastructure;
using BasicWMS.Data.Repositories;
using BasicWMS.Service;

namespace BasicWMS
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            SetAutofacConfig(); 
            AutoMapperConfiguration.Configure();
        }

        private static void SetAutofacConfig()
        {
            var builder = new ContainerBuilder();
            var dataAccess = Assembly.GetExecutingAssembly();

            //Register your MVC controllers
            builder.RegisterControllers(dataAccess);

            //Register dependencies in filter attributes
            //builder.RegisterFilterProvider();

            //Register dependencies in custom views
            //builder.RegisterSource(new ViewRegistrationSource());

            //Register our Data dependencies
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            //builder.RegisterType<ProductController>().InstancePerRequest();

            // Repositories
            builder.RegisterAssemblyTypes(dataAccess)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();
            // Services
            builder.RegisterAssemblyTypes(dataAccess)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}