using ProductInfoService.Data.Interfaces;
using ProductInfoService.Domain;

namespace ProductInfoService.Data.Repositories;

public class ProductRepository : IProductRepository
{
    public Product GetProductById(int id)
    {
       
        return new Product
        {
            Id = id,
            Price = 99.99m,
            Description = "Dummy Product",
            StockStatus = "In Stock",
            Images = new List<string> { "dummy1.jpg", "dummy2.jpg" }
        };
    }
}

