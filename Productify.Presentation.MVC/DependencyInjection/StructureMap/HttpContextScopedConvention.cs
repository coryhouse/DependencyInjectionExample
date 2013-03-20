using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Productify.Presentation.DependencyInjection.StructureMap
{
	public class HttpContextScopedConvention : IRegistrationConvention
	{
		public void Process(Type type, Registry registry)
		{
			registry.For(type).HttpContextScoped();
		}
	}
}