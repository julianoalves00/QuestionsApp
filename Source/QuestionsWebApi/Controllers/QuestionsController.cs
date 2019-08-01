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
        [HttpGet]
        public Question Get(long id)
        {
            Question question = null;
            try
            {
                QuestionsFacade facade = new QuestionsFacade();

                question = facade.GetQuestion(id);
            }
            catch (Exception ex)
            {
                WriteLog.AddEventLogEntry(ex);
            }
            return question;
        }
        //GET api/questions?limit={limit}&offset={offset}&filter={filter}
        [HttpGet]
        public IList<Question> Get(int limit, int offset, string filter)
        {
            IList<Question> questions = null;
            try
            {
                QuestionsFacade facade = new QuestionsFacade();

                questions = facade.GetQuestion(filter, limit, offset);
            }
            catch (Exception ex)
            {
                WriteLog.AddEventLogEntry(ex);
            }
            return questions;
        }

        // POST api/questions
        [HttpPost]
        public Question Post(Question question)
        {
            Question returnValue = null;
            try
            {
                QuestionsFacade facade = new QuestionsFacade();
                returnValue = facade.Save(question);
            }
            catch (Exception ex)
            {
                WriteLog.AddEventLogEntry(ex);
            }
            return returnValue;
        }
    }
}
