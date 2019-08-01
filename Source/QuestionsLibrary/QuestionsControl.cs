using QuestionsLibrary.Entities;
using QuestionsLibrary.General;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Configuration;
using System.Net.Mail;
using System.Configuration;

namespace QuestionsLibrary
{
    internal class QuestionsControl : IQuestionsControl
    {
        public Question Save(Question entity)
        {
            using (var ctx = new QuestionsContext())
            {
                ctx.Questions.Add(entity);
                ctx.SaveChanges();
            }

            return entity;
        }
        public void Update(Question entity)
        {
            using (var ctx = new QuestionsContext())
            {
                var entUpdate = ctx.Questions.Find(entity.ID);
                entUpdate.Description = entity.Description;
                entUpdate.Number = entity.Number;

                ctx.SaveChanges();
            }
        }
        public void Delete(Question entity)
        {
            Delete(entity.ID);
        }
        public void Delete(long idQuestion)
        {
            using (var ctx = new QuestionsContext())
            {
                var entRemove = ctx.Questions.Find(idQuestion);
                ctx.Questions.Remove(entRemove);
                ctx.SaveChanges();
            }
        }

        public bool Health()
        {
            bool returnValue = true;
            try
            {
                using (var ctx = new QuestionsContext())
                {
                    var item = ctx.Questions.FirstOrDefault();

                    if (item == null)
                        returnValue = false;
                }
            }
            catch (Exception)
            {
                returnValue = false;
            }
            return returnValue;
        }
        public IList<Question> GetQuestion(string filter = null, int limit = 0, int offset = 0)
        {
            IList<Question> returnValue = null;

            try
            {
                bool useSkipAndTake = limit > 0 && offset > 0;

                using (var ctx = new QuestionsContext())
                {
                    // Change this to using a dynamic predicate
                    if (string.IsNullOrEmpty(filter))
                    {
                        if (useSkipAndTake)
                            returnValue = ctx.Questions.OrderBy(x => x.ID).Skip(offset).Take(limit).ToList();
                        else
                            returnValue = ctx.Questions.OrderBy(x => x.ID).ToList();
                    }
                    else
                    {
                        if (useSkipAndTake)
                            returnValue = ctx.Questions.Where(x => x.Description.Contains(filter)).OrderBy(x => x.ID).Skip(offset).Take(limit).ToList();
                        else
                            returnValue = ctx.Questions.Where(x => x.Description.Contains(filter)).OrderBy(x => x.ID).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnValue;
        }
        public Question GetQuestion(long idQuestion)
        {
            Question returnValue = null;

            try
            {
                using (var ctx = new QuestionsContext())
                {
                    returnValue = ctx.Questions.Find(idQuestion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnValue;
        }

        public void ShareByEmail(string email, string urlContent)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                    throw new Exception("Email is necessary.");

                string subject = "Question Detail";
                string body = "<br />Details of question<br /><br />Thanks";
                if (!string.IsNullOrEmpty(urlContent))
                    using (WebClient client = new WebClient())
                    {
                        body = client.DownloadString(urlContent);
                    }

                // Get settings from .Config
                SmtpSection smtpSection = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");

                EmailTools.Send2(smtpSection.Network.Host, 
                    smtpSection.Network.Port, 
                    smtpSection.Network.UserName, 
                    smtpSection.Network.Password, 
                    smtpSection.From, 
                    email, 
                    subject, 
                    body);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

