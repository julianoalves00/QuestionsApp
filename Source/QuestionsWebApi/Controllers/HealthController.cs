using QuestionsLibrary;
using QuestionsLibrary.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuestionsWebApi.Controllers
{
    public class HealthController : ApiController
    {
        // GET api/health
        public bool Get()
        {
            bool returnValue = false;
            try
            {
                QuestionsFacade facade = new QuestionsFacade();

                returnValue = facade.Health();
            }
            catch (Exception ex)
            {
                WriteLog.AddEventLogEntry(ex);
            }
            return returnValue;
        }
    }
}
