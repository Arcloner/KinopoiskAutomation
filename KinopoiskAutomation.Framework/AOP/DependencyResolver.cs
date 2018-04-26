using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinopoiskAutomation.Framework.AOP
{
    public class DependencyResolver
    {
        private IWindsorContainer _container;

        //Initialize the container
        public DependencyResolver()
        {
            if (_container == null)
            {
                _container = new WindsorContainer();
                _container.Register(new ComponentRegistration());
            }
        }

        //Resolve types
        public T For<T>(Guid DriverKey)
        {
            Dictionary<string, object> arguments = new Dictionary<string, object>();
            arguments.Add("DriverKey", DriverKey);
            return _container.Resolve<T>(arguments);
        }
    }
}
