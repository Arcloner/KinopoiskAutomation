using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinopoiskAutomation.Framework.AOP
{
    public class PageLoggingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            bool ExecutedWithoutExeptions = false;
            while (ExecutedWithoutExeptions == false)
            {
                try
                {
                    //((BasePage)invocation.InvocationTarget).SwitchWindow();
                    //WebDriverWaiter.WaitForDOMLoad();
                    //WebDriverWaiter.WaitForAjaxLoad();
                    invocation.Proceed();
                    ExecutedWithoutExeptions = true;
                }
                catch (Exception e)
                {
                    //Exception                    
                }
                finally
                {
                    //Exiting Method
                }
            }
        }
    }
}
