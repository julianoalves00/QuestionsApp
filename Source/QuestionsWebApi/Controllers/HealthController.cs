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
        /// <summary>
        /// Check the server health, testing if it is possible to query an item in the database
        /// </summary>
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
