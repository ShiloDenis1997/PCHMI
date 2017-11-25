using Autofac;
using Module = Autofac.Module;
using MinskForYou.Api.Services;
using MinskForYou.Api.Interfaces.Services;

namespace MinskForYou.Api {

	public class LogicModule : Module {

		protected override void Load(ContainerBuilder builder) {
			builder.RegisterType<LoginService>().As<ILoginService>().SingleInstance();
			builder.RegisterType<PlaceService>().As<IPlaceService>().SingleInstance();
			builder.RegisterType<CommentService>().As<ICommentService>().SingleInstance();
		}
	}

}