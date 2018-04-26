using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinopoiskAutomation.Framework.AOP
{
    public class ComponentRegistration : IRegistration
    {
        public void Register(IKernelInternal kernel)
        {
            kernel.Register(
                Component.For<PageLoggingInterceptor>()
                    .ImplementedBy<PageLoggingInterceptor>());


            //Pages
            //kernel.Register(
            //    Component.For<IStartPage>()
            //             .ImplementedBy<StartPage>()
            //             .Interceptors(InterceptorReference.ForType<PageLoggingInterceptor>()).Anywhere);           
        }
    }
}
