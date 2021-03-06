using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Presenters.Common;
using LightInject;

namespace WinFormsAppSimulation
{
    public class LightInjectAdapter : IContainer
    {
        private readonly ServiceContainer _container = new ServiceContainer();

        public void Register<TService, TImplementation>() where TImplementation : TService => 
            _container.Register<TService, TImplementation>();

        public void Register<TService>() => 
            _container.Register<TService>();

        public void RegisterInstance<T>(T instance) => 
            _container.RegisterInstance(instance);

        public void Register<TService, TArgument>(Expression<Func<TArgument, TService>> factory) =>
            _container.Register(serviceFactory => factory);

        public TService Resolve<TService>() => 
            _container.GetInstance<TService>();

        public bool IsRegistered<TService>() => 
            _container.CanGetInstance(typeof(TService), string.Empty);
    }
}
