using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Productify.Data.Dapper;
using Productify.Domain.Repositories;
using Productify.Domain.Services;

namespace Productify.Presentation.DependencyInjection.CastleWindsor
{
	public class WindsorInstaller : IWindsorInstaller
	{
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.Register(
				Component.For<IProductRepository>().ImplementedBy<ProductRepository>(),
				Component.For<IProductService>().ImplementedBy<ProductService>()
				);
		}
	}
}