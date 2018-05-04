using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using KinopoiskAutomation.Framework.PageObjects;
using KinopoiskAutomation.Framework.PageObjects.Interfaces;

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
            kernel.Register(
            Component.For<IStartPage>()
                     .ImplementedBy<StartPage>()
                     .Interceptors(InterceptorReference.ForType<PageLoggingInterceptor>()).Anywhere);

        }
    }
}
