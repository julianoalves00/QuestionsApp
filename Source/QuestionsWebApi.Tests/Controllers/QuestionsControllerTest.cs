using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestionsLibrary.Entities;
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
                // Arrange
                QuestionsController controller = new QuestionsController();

                // Act
                Question result = controller.Get(5);

                // Assert
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
                // Arrange
                QuestionsController controller = new QuestionsController();

                // Act
                IList<Question> result = controller.Get(10, 2, "Wh");

                // Assert
                Assert.AreEqual(10, result.Count);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(true, false, ex.Message);
            }
        }
    }
}
