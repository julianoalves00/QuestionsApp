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
            try
            {
                QuestionsFacade facade = new QuestionsFacade();

                question = facade.GetQuestion(id);
            }
            catch (QuestionLibaryException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                WriteLog.AddEventLogEntry(ex);
            }
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
            try
            {
                QuestionsFacade facade = new QuestionsFacade();

                questions = facade.GetQuestion(filter, limit, offset);
            }
            catch (QuestionLibaryException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                WriteLog.AddEventLogEntry(ex);
            }
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
            try
            {
                QuestionsFacade facade = new QuestionsFacade();
                returnValue = facade.SaveOrUpdate(question);
            }
            catch (QuestionLibaryException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                WriteLog.AddEventLogEntry(ex);
            }
            return returnValue;
        }

        [HttpDelete]
        public void Delete(long id)
        {
            try
            {
                QuestionsFacade facade = new QuestionsFacade();
                facade.Delete(id);
            }
            catch (QuestionLibaryException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                WriteLog.AddEventLogEntry(ex);
            }
        }
    }
}
