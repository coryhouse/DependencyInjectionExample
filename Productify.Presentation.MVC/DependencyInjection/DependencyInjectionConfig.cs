using System;
using System.Web.Mvc;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using Productify.Data.Dapper;
using Productify.Domain.Repositories;
using Productify.Domain.Services;
using Productify.Presentation.DependencyInjection.CastleWindsor;
using Productify.Presentation.DependencyInjection.PoorMansDI;
using Productify.Presentation.DependencyInjection.StructureMap;
using StructureMap;
using Productify.Domain.Model;

namespace Productify.Presentation.DependencyInjection
{
	/// <summary>
	/// The application's composition root
	/// </summary>
	public class DependencyInjectionConfig
	{
		public static void RegisterControllerFactory()
		{
			var controllerFactory = PoorMansDi();
			//var controllerFactory = CastleWindsorXML();
			//var controllerFactory = CastleWindsorFluent();
			//var controllerFactory = StructureMapFluent();
			//var controllerFactory = StructureMapXml();
			//var controllerFactory = StructureMapConvention();
			//var controllerFactory = CastleWindsorConvention();
			ControllerBuilder.Current.SetControllerFactory(controllerFactory);
		}

		private static IControllerFactory PoorMansDi()
		{
			return new PoorMansDiControllerFactory();
		}

		private static IControllerFactory StructureMapFluent()
		{
			var container = new Container();
			container.Configure(c =>
			{
				c.For<IProductRepository>().Use<AuditingProductRepository>();
				c.For<IProductService>().Use<ProductService>();
				c.For<IAuditor>().Use<Auditor>();
			});

			return new StructureMapControllerFactory(container);
		}

		private static IControllerFactory StructureMapConvention()
		{
			var container = new Container();
			container.Configure(c => c.AddRegistry<StructureMapRegistry>());

			return new StructureMapControllerFactory(container);
		}

		private static IControllerFactory StructureMapXml()
		{
			var container = new Container();
			var configName = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
			container.Configure(r=>r.AddConfigurationFromXmlFile(configName));
			return new StructureMapControllerFactory(container);
		}

		private static IControllerFactory CastleWindsorFluent()
		{
			IWindsorContainer container = new WindsorContainer();
			container.Install(new WindsorInstaller());
			return new WindsorControllerFactory(container);
		}

		private static IControllerFactory CastleWindsorXML()
		{
			var container = new WindsorContainer(new XmlInterpreter());
			return container.Resolve<IControllerFactory>();
		}

		private static IControllerFactory CastleWindsorConvention()
		{
			//IWindsorContainer container = new WindsorContainer();
			//container.Install(new CommerceWindsorInstaller());
			//return new WindsorControllerFactory(container);
			throw new NotImplementedException();
		}
	}
}