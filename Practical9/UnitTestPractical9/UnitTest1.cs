using System;
using System.Web.Mvc;
using Practical9.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPractical9
{
    [TestClass]
    public class DisplayStringControllerTests
    {
        [TestMethod]
        public void Index_Should_Return_HelloWorld_View()
        {
            // Arrange
            DisplayStringController controller = new DisplayStringController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hello World", result.ViewBag.Message);
        }
    }

}
