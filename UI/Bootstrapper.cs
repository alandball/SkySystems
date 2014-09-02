using System.Web.Mvc;
using Common.Users;
using Data.Repositories;
using Microsoft.Practices.Unity;
using Unity.Mvc3;

namespace UI
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
 
            //Services
            container.RegisterType<IUserService, UserService>();

            //Repositories
            container.RegisterType<IUserRepository, UserRepository>();

            return container;
        }
    }
}