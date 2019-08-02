using QuestionsLibrary;
using QuestionsLibrary.Entities;
using QuestionsLibrary.General;
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
        /// <summary>
        /// Get the question by ID
        /// </summary>
        [HttpGet]
        public Question Get(long id)
        {
            Question question = null;

            QuestionsFacade facade = new QuestionsFacade();

            question = facade.GetQuestion(id);

            return question;
        }
        // GET api/questions?limit={limit}&offset={offset}&filter={filter}
        /// <summary>
        /// Get a list of questions allowing filter by description, limit of itens an offset
        /// </summary>
        [HttpGet]
        public IList<Question> Get(int limit, int offset, string filter)
        {
            IList<Question> questions = null;

            QuestionsFacade facade = new QuestionsFacade();

            questions = facade.GetQuestion(filter, limit, offset);

            return questions;
        }

        // POST api/questions
        /// <summary>
        /// Save / Create a nem question using a post method
        /// </summary>
        [HttpPost]
        public Question Post(Question question)
        {
            Question returnValue = null;

            QuestionsFacade facade = new QuestionsFacade();
            returnValue = facade.SaveOrUpdate(question);

            return returnValue;
        }

        [HttpDelete]
        public bool Delete(long id)
        {
            bool returnValue = false;

            QuestionsFacade facade = new QuestionsFacade();
            returnValue = facade.Delete(id);

            return returnValue;
        }
    }
}
