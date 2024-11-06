using ProductInfoService.Data.Interfaces;
using ProductInfoService.Models;

namespace ProductInfoService.Data.Repositories;

public class ProductRepository : IProductRepository
{
    public Product GetProductById(int id)
    {
        // Returnerar dummy-data
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

