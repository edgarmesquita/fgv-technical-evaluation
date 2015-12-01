using System;
using FGV.TechnicalEvaluation.Domain.Services;
using FGV.TechnicalEvaluation.Foundation.Contracts;
using FGV.TechnicalEvaluation.Foundation.Contracts.Services;
using Microsoft.Practices.Unity;

namespace FGV.TechnicalEvaluation.Application
{
    public static class UnityConfig
    {
        private static Lazy<IUnityContainer> _container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return _container.Value;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IApplicationContext, ApplicationContext>();
            container.RegisterType<IBooksOrderer, BooksOrderer>();


            container.RegisterType<MainForm>();
        }
    }
}
