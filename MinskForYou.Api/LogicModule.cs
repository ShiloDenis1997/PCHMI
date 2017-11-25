using System.Linq;
using System.Reflection;
using Autofac;
using Module = Autofac.Module;
using MinskForYou.Api.Services;
using MinskForYou.Api.Interfaces.Services;

namespace MinskForYou.Api {

	public class LogicModule : Module {
		protected override void Load(ContainerBuilder builder) {

			builder.RegisterType<PlaceService>().As<IPlaceService>().SingleInstance();
	

			//builder.RegisterType<SelfTestContainer>().As<ISelfTestContainer>().SingleInstance();

			//AppContext.RegisterEntityChangesTrigger<User, IUserManager>();
			//AppContext.RegisterEntityChangesTrigger<InternalResource, IInternalResourceManager>();
			//AppContext.RegisterEntityChangesTrigger<ExternalResource, IExternalResourceManager>();
			//AppContext.RegisterEntityChangesTrigger<GroupSecurableObjectRole, IResourceSecurityManager>();
			//AppContext.RegisterEntityChangesTrigger<Group, IGroupManager>();
			//AppContext.RegisterEntityChangesTrigger<Company, ICompanyManager>();
			//AppContext.RegisterEntityChangesTrigger<DictationNetwork, IDictationNetworkManager>();
		}
	}
}