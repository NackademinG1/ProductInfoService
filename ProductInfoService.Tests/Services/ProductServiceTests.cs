using Moq;
using ProductInfoService.Business.Services;
using ProductInfoService.Data.Interfaces;
using ProductInfoService.Models;

namespace ProductInfoService.Tests.Services
{
    public class ProductServiceTests
    {
        [Fact]
        public void GetProductById_ValidId_ReturnsProduct()
        {
            // Arrange
            int productId = 1;
            var mockProductRepository = new Mock<IProductRepository>();

            var expectedProduct = new Product
            {
                Id = productId,
                Price = 99.99m,
                Description = "Test Product",
                StockStatus = "In Stock",
                Images = new List<string> { "image1.jpg", "image2.jpg" }
            };

            mockProductRepository.Setup(repo => repo.GetProductById(productId))
                .Returns(expectedProduct);

            var productService = new ProductService(mockProductRepository.Object);

            // Act
            var actualProduct = productService.GetProductById(productId);

            // Assert
            Assert.NotNull(actualProduct);
            Assert.Equal(expectedProduct.Id, actualProduct.Id);
            Assert.Equal(expectedProduct.Price, actualProduct.Price);
            Assert.Equal(expectedProduct.Description, actualProduct.Description);
            Assert.Equal(expectedProduct.StockStatus, actualProduct.StockStatus);
            Assert.Equal(expectedProduct.Images, actualProduct.Images);
        }
    }
}
