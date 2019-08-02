using QuestionsLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsLibrary
{
    public interface IQuestionsControl
    {
        Question Save(Question entity);
        Question Update(Question entity);
        Question SaveOrUpdate(Question entity);
        bool Delete(Question entity);
        bool DeleteById(long idQuestion);
        bool Health();
        IList<Question> GetQuestion(string filter = null, int limit = 0, int offset = 0);
        Question GetQuestion(long idQuestion);
        bool ShareByEmail(string email, string urlContent);
    }
}
