using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestionsLibrary.Entities;
using QuestionsLibrary.General;
using QuestionsWebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsWebApi.Tests.Controllers
{
    [TestClass]
    public class QuestionsControllerTest
    {
        [TestMethod]
        public void GetById()
        {
            try
            {
                QuestionsController controller = new QuestionsController();

                Question result = controller.Get(5);

                Assert.AreEqual(5, result.ID);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(true, false, ex.Message);
            }
        }

        [TestMethod]
        public void GetFilterOffSet()
        {
            try
            {
                QuestionsController controller = new QuestionsController();

                IList<Question> result = controller.Get(10, 2, "Wh");

                Assert.AreEqual(10, result.Count);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(true, false, ex.Message);
            }
        }

        [TestMethod]
        public void Post()
        {
            bool itemNotExists = false;
            try
            {
                QuestionsController controller = new QuestionsController();

                // test save
                Question question = new Question { Description = "Why and How?", Number = 199 };

                Question retValue = controller.Post(question);

                Assert.AreEqual(true, retValue.ID > 0);

                // test update
                question.Description = "What is your LAST name?";
                question.Number = 200;

                retValue = controller.Post(question);

                Assert.AreEqual(true, retValue.Number == 200);

                // test delete
                controller.Delete(question.ID);

                retValue = controller.Get(question.ID);

                Assert.AreEqual(true, retValue == null);

                // test update item not exists, throw exception
                itemNotExists = true;
                question.ID = 1001;

                retValue = controller.Post(question);
            }
            catch (QuestionLibaryException ex)
            {
                Assert.AreEqual(true, itemNotExists && ex.Message.Contains("does not exist"));
            }
            catch (Exception ex)
            {
                Assert.AreEqual(true, false, ex.Message);
            }
        }
    }
}
