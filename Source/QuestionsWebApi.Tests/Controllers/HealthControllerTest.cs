using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestionsWebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsWebApi.Tests.Controllers
{
    [TestClass]
    public class HealthControllerTest
    {
        [TestMethod]
        public void Get()
        {
            try
            {
                // Arrange
                HealthController controller = new HealthController();

                // Act
                bool result = controller.Get();

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(true, result);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(true, false, ex.Message);
            }
        }
    }
}
