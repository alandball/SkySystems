using System.Web.Mvc;
using Common.Addresses;
using Common.AddressTypes;
using Common.Authentications;
using Common.Clients;
using Common.ClientTypes;
using Common.Orders;
using Common.StockLogs;
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
            container.RegisterType<IAddressService, AddressService>();
            container.RegisterType<IAddressTypeService, AddressTypeService>();
            container.RegisterType<IAuthenticationService, AuthenticationService>();
            container.RegisterType<IClientService, ClientService>();
            container.RegisterType<IClientTypeService, ClientTypeService>();
            container.RegisterType<IOrderService, OrderService>();
            container.RegisterType<IStockLogService, StockLogService>();

            //Repos
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IAddressRepository, AddressRepository>();
            container.RegisterType<IAddressTypeRepository, AddressTypeRepository>();
            container.RegisterType<IAuthenticationRepository, AuthenticationRepository>();
            container.RegisterType<IClientRepository, ClientRepository>();
            container.RegisterType<IClientTypeRepository, ClientTypeRepository>();
            container.RegisterType<IOrderRepository, OrderRepository>();
            container.RegisterType<IStockLogRepository, StockLogRepository>();

            return container;
        }
    }
}