using System;
using System.Web.Mvc;
using Practical9.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPractical9
{
    [TestClass]
    public class Test1ControllerTests
    {
        [TestMethod]
        public void Index_Should_Return_HelloWorld_View()
        {
            // Arrange
            Test1Controller controller = new Test1Controller();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hello World", result.ViewBag.Message);
        }
    }

}
