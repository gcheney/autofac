using System;
using System.Collections.Generic;
using AutofacWebApp.Controllers;
using AutofacWebApp.Models;
using AutofacWebApp.Services;
using Moq;
using Xunit;

namespace AutofacWebApp.Tests
{
    public class ProductControllerTests
    {
        private readonly Product _sampleProduct = new Product()
        {
            Id = 101,
            DateCreated = new DateTime(2017, 1, 7),
            Name = "Generic Product"
        };

        [Fact]
        public void List_Products_Calls_Repository_And_Lists_Products()
        {
            // Arrange
            var sampleProduct = GetSampleProduct();
            var expectedProducts = new List<Product> { sampleProduct };
            var retrievalCount = expectedProducts.Count;
            const int startIndex = 0;

            var repositoryMock = new Mock<IProductRepository>();
            repositoryMock.Setup(repo => repo.ListProducts(startIndex, retrievalCount))
                .Returns(expectedProducts);

            var productController = new ProductController(repositoryMock.Object);

            // Act 
            var actualProducts = productController.ListProducts(retrievalCount);

            // Assert 
            Assert.Equal(expectedProducts, actualProducts);
        }

        [Fact]
        public void Add_Product_Calls_Repository_And_Product()
        {
            // Arrange
            Product createdProduct = null;
            var sampleProduct = GetSampleProduct();
            var repositoryMock = new Mock<IProductRepository>();
            repositoryMock.Setup(repo => repo.Add(_sampleProduct))
                .Callback<Product>(product => { createdProduct = product; });

            var productController = new ProductController(repositoryMock.Object);

            // Act 
            productController.Add(sampleProduct);

            // Assert 
            Assert.Equal(sampleProduct, createdProduct);
        }

        private static Product GetSampleProduct()
        {
            return new Product()
            {
                Id = 101,
                DateCreated = new DateTime(2017, 1, 7),
                Name = "Generic Product"
            };
        }
    }
}