using System.Web.Mvc;
using Productify.Domain.Model;
using Productify.Domain.Services;
using Productify.Presentation.Controllers;
using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Productify.Data.Dapper;

namespace Productify.Presentation.DependencyInjection.StructureMap
{
	public class StructureMapRegistry : Registry
	{
		public StructureMapRegistry()
		{
			//Use HTTP Context lifetime for all controllers.
			this.Scan(x =>
				          {
					          x.AssemblyContainingType<HomeController>();
					          x.AddAllTypesOf<IController>();
					          x.Include(t => typeof (IController).IsAssignableFrom(t));
					          x.Convention<HttpContextScopedConvention>();
				          });

			//Wire all services to use the first interface found in the assembly containing ProductService.
			//Set all instances to operate as singletons since the service objects are stateless
			this.Scan(x =>
			{
				x.AssemblyContainingType<ProductService>();
				x.AssemblyContainingType<Product>();
				x.RegisterConcreteTypesAgainstTheFirstInterface();
				x.Include(t => t.Name.EndsWith("Service"));
				x.Include(t => t.Name.EndsWith("Auditor"));
				x.Convention<SingletonConvention>();
			});

			//Wire all repositories to use the first interface found. 
			//Use the default scope (aka lifecycle) of transient
			this.Scan(x =>
			{
				x.AssemblyContainingType<ProductRepository>();
				x.RegisterConcreteTypesAgainstTheFirstInterface();
				x.Include(t => t.Name.EndsWith("Repository"));
			});
		}
	}
}