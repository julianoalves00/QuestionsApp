using QuestionsLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsLibrary
{
    internal interface IQuestionsControl
    {
        Question Save(Question entity);
        void Update(Question entity);
        void Delete(Question entity);
        void Delete(long idQuestion);
        bool Health();
        IList<Question> GetQuestion(string filter = null, int limit = 0, int offset = 0);
        Question GetQuestion(long idQuestion);
        void ShareByEmail(string email, string urlContent);
    }
}
