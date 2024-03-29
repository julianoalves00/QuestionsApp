﻿using QuestionsLibrary;
using QuestionsLibrary.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuestionsWebApi.Controllers
{
    public class ShareController : ApiController
    {
        // POST api/share?destination_email={destination_email}&content_url={content_url}
        /// <summary>
        /// Share the content of a URL in email
        /// </summary>
        public void Post([FromBody]string destination_email, [FromBody]string content_url)
        {
            QuestionsFacade facade = new QuestionsFacade();

            facade.ShareByEmail(destination_email, content_url);
        }
    }
}
