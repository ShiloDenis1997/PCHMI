using System;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Reflection;

namespace MinskForYou.Api.App_Start {
	public class DiConfig : IDisposable {
		public IContainer Container { get; private set; }

		private IContainer BuildContainer() {
			var builder = new ContainerBuilder();

			builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

			builder.RegisterModule(new LogicModule());

			return builder.Build();
		}

		public void Configure(HttpConfiguration config) {
			Container = BuildContainer();

			config.DependencyResolver = new AutofacWebApiDependencyResolver(Container);

			//This tells the MVC application to use Container as its dependency resolver
			DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));
		}

		public void Dispose() {
			Container.Dispose();
		}
	}
}