using QuestionsLibrary;
using QuestionsLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuestionsWebApi.Controllers
{
    public class QuestionsController : ApiController
    {
        // GET api/questions/5
        public Question Get(long id)
        {
            QuestionsFacade facade = new QuestionsFacade();

            Question question = facade.GetQuestion(id);

            return question;
        }
        //GET api/questions?limit={limit}&offset={offset}&filter={filter}
        public IList<Question> Get(int limit, int offset, string filter)
        {
            QuestionsFacade facade = new QuestionsFacade();

            IList<Question> questions = facade.GetQuestion(filter, limit, offset);

            return questions;
        }
    }
}
