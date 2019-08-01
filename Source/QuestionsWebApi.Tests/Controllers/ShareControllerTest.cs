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
    public class ShareControllerTest
    {
        [TestMethod]
        public void Post()
        {
            try
            {
                ShareController controller = new ShareController();

                controller.Post("julianoalves@gmail.com", "https://ajuda.sapo.pt/");

                Assert.AreEqual(true, true);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(true, false, ex.Message);
            }
        }
    }
}
