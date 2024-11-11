using ProductInfoService.Domain;

namespace ProductInfoService.Data.Interfaces;

public interface IProductRepository
{
    Product GetProductById(int id);
}

