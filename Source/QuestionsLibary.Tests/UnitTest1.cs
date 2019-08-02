using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestionsLibrary;
using QuestionsLibrary.Entities;
using System.Collections.Generic;

namespace QuestionsLibary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CrudQuestion()
        {
            try
            {
                QuestionsFacade facade = new QuestionsFacade();
                Question question = new Question() { Description = "Where and When?", Number = 99 };

                // Create
                facade.Save(question);

                // Read by ID
                question = facade.GetQuestion(question.ID);

                // Update
                question.Description = "***" + question.Description;
                question.Number = question.Number + 1000;
                facade.Update(question);

                // Delete
                facade.Delete(question.ID);

                Assert.AreEqual(true, true, "Sucesso!!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(true, false, ex.Message);
            }

        }

        [TestMethod]
        public void ServerHealth()
        {
            try
            {
                QuestionsFacade facade = new QuestionsFacade();
                bool health = facade.Health();

                Assert.AreEqual(true, true, "Sucesso!!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(true, false, ex.Message);
            }

        }

        [TestMethod]
        public void GetQuestionByID()
        {
            try
            {
                QuestionsFacade facade = new QuestionsFacade();

                Question question = facade.GetQuestion(5);

                Assert.AreEqual(true, true, "Sucesso!");
            }
            catch(Exception ex)
            {
                Assert.AreEqual(true, false, ex.Message);
            }

        }

        [TestMethod]
        public void GetQuestions()
        {
            try
            {
                QuestionsFacade facade = new QuestionsFacade();
                // Get all
                IList<Question> questions = facade.GetQuestion();
                // Get by description
                questions = facade.GetQuestion("Is Your");
                // Get by description, and offset
                questions = facade.GetQuestion("a");
                questions = facade.GetQuestion("a", 10, 10);

                Assert.AreEqual(true, true, "Sucesso!!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(true, false, ex.Message);
            }
        }

        [TestMethod]
        public void SendMail()
        {
            try
            {
                QuestionsFacade facade = new QuestionsFacade();

                //bool returnValue = facade.ShareByEmail("juliano.alves@widescope.pt", null);
                bool returnValue = facade.ShareByEmail("julianoalves@gmail.com", "https://ajuda.sapo.pt/");

                Assert.AreEqual(true, returnValue);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(true, false, ex.Message);
            }
        }
    }
}
