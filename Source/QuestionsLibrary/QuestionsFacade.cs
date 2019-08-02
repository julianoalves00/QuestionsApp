using QuestionsLibrary.DynamicProxy;
using QuestionsLibrary.Entities;
using QuestionsLibrary.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsLibrary
{
    public class QuestionsFacade
    {
        private IQuestionsControl QuestionControlInstance 
        {
            get
            {
                // Instance QuestionsControl using a proxy
                IQuestionsControl qControl = (IQuestionsControl)ControlProxy.NewInstance(new QuestionsControl());
                return qControl;
            }
        }
        public Question Save(Question entity)
        {
            return QuestionControlInstance.Save(entity);
        }
        public void Update(Question entity)
        {
            QuestionControlInstance.Update(entity);
        }
        public Question SaveOrUpdate(Question entity) 
        {
            return QuestionControlInstance.SaveOrUpdate(entity);
        }
        public bool Delete(Question entity)
        {
            return QuestionControlInstance.Delete(entity);
        }
        public bool Delete(long idQuestion)
        {
            return QuestionControlInstance.DeleteById(idQuestion);
        }

        public bool Health() 
        {
            return QuestionControlInstance.Health();
        }
        public IList<Question> GetQuestion(string filter = null, int limit = 0, int offset = 0) 
        {
            return QuestionControlInstance.GetQuestion(filter, limit, offset);
        }
        public Question GetQuestion(long idQuestion)
        {
            return QuestionControlInstance.GetQuestion(idQuestion);
        }

        public bool ShareByEmail(string email, string urlContent)
        {
            return QuestionControlInstance.ShareByEmail(email, urlContent);
        }
    }
}
