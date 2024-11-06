using ProductInfoService.Business.Interfaces;
using ProductInfoService.Data.Interfaces;
using ProductInfoService.Models;

namespace ProductInfoService.Business.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Product GetProductById(int id)
    {
        return _productRepository.GetProductById(id);
    }
}

