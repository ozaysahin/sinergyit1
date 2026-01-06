using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using sinergyit.Entities;
using sinergyit.Repos;
using sinergyit.Services;
using Xunit;

namespace sinergyit.xunit
{
    public class ProductServiceTests
    {
        [Fact]
        public void GetAll_ProductsTest()
        {
            var repoMock = new Mock<IProductRepository>();

            repoMock.Setup(x => x.GetAll())
                .Returns(new List<Product>
                {
            new Product { Name = "Kalem", Price = 10 }
                });

            var service = new ProductService(repoMock.Object);

            var result = service.GetAll();

            Assert.Single(result);
        }

        [Theory]
        [InlineData("Kalem", 10)]
        [InlineData("Defter", 20)]
        [InlineData("Silgi", 5)]
        public void Add_ProductTest(string name, decimal price)
        {
            var repoMock = new Mock<IProductRepository>();
            var service = new ProductService(repoMock.Object);

            var product = new Product
            {
                Name = name,
                Price = price
            };

            service.Add(product);

            repoMock.Verify(x => x.Add(It.IsAny<Product>()), Times.Once);
        }

    }
}
