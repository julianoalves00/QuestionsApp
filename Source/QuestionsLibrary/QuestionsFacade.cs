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
        private IQuestionsControl QControl 
        {
            get
            {
                return new QuestionsControl();
            }
        }
        public Question Save(Question entity)
        {
            return QControl.Save(entity);
        }
        public void Update(Question entity)
        {
            QControl.Update(entity);
        }
        public Question SaveOrUpdate(Question entity) 
        {
            return QControl.SaveOrUpdate(entity);
        }
        public void Delete(Question entity)
        {
            QControl.Delete(entity);
        }
        public void Delete(long idQuestion)
        {
            QControl.Delete(idQuestion);
        }

        public bool Health() 
        {
            return QControl.Health();
        }
        public IList<Question> GetQuestion(string filter = null, int limit = 0, int offset = 0) 
        {
            return QControl.GetQuestion(filter, limit, offset);
        }
        public Question GetQuestion(long idQuestion)
        {
            return QControl.GetQuestion(idQuestion);
        }

        public void ShareByEmail(string email, string urlContent)
        {
            QControl.ShareByEmail(email, urlContent);
        }
    }
}
