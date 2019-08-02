using QuestionsLibrary.General;
using System;

namespace QuestionsLibrary.DynamicProxy
{
    /// <summary>
    /// Test proxy invocation handler which is used to control handling errors
    /// before invoking the method
    /// </summary>
    public class ControlProxy : IProxyInvocationHandler
    {
        Object obj = null;

        ///<summary>
        /// Class constructor
        ///</summary>
        ///<param name="obj">Instance of object to be proxied</param>
        private ControlProxy(Object obj)
        {
            this.obj = obj;
        }

        ///<summary>
        /// Factory method to create a new proxy instance.
        ///</summary>
        ///<param name="obj">Instance of object to be proxied</param>
        public static Object NewInstance(Object obj)
        {
            return ProxyFactory.GetInstance().Create(
                new ControlProxy(obj), obj.GetType());
        }

        ///<summary>
        /// IProxyInvocationHandler method that gets called from within the proxy
        /// instance. 
        ///</summary>
        ///<param name="proxy">Instance of proxy</param>
        ///<param name="method">Method instance 
        public Object Invoke(Object proxy, System.Reflection.MethodInfo method, Object[] parameters)
        {

            Object retVal = null;

            try
            {
                retVal = method.Invoke(obj, parameters);
            }
            catch (QuestionLibaryException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                if (ex.InnerException is QuestionLibaryException)
                {
                    throw ex.InnerException;
                }
                else
                {
                    WriteLog.AddEventLogEntry(ex);
                    throw ex;
                }
            }
            return retVal;
        }
    }
}
