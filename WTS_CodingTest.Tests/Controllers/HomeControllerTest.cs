using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WTS_CodingTest.Controllers;

namespace WTS_CodingTest.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
