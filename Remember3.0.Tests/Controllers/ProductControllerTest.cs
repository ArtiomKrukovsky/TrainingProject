using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Remember3._0.Controllers;
using Remember3._0.Domain.Interfaces;
using Remember3._0.Domain.Models;

namespace Remember3._0.Tests.Controllers
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void GetProductsISNotNull()
        {
            // Arrange
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(a => a.Products.GetAll()).Returns(new List<Product>());
            ProductController controller = new ProductController(mock.Object);

            // Act
            ViewResult result = controller.GetProducts() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }
    }
}
