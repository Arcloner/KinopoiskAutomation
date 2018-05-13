using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using KinopoiskAutomation.AOP;
using KinopoiskAutomation.Workspace.PageObjects;
using KinopoiskAutomation.Workspace.PageObjects.Interfaces;

namespace KinopoiskAutomation.Workspace.IoC
{
    public class PageObjectsRegistration: IRegistration
    {
        public void Register(IKernelInternal kernel)
        {
            kernel.Register(
                Component.For<PageLoggingInterceptor>()
                    .ImplementedBy<PageLoggingInterceptor>());


            //Pages registration
            kernel.Register(
            Component.For<IStartPage>()
                     .ImplementedBy<StartPage>()
                     .Interceptors(InterceptorReference.ForType<PageLoggingInterceptor>()).Anywhere);

            kernel.Register(
           Component.For<IResultsOfSearch>()
                    .ImplementedBy<ResultsOfSearch>()
                    .Interceptors(InterceptorReference.ForType<PageLoggingInterceptor>()).Anywhere);

        }
    }
}
