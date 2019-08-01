using QuestionsLibrary;
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
            QuestionsFacade facade = new QuestionsFacade();

            return facade.Health();
        }
    }
}
