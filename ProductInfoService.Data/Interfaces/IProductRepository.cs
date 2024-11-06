using ProductInfoService.Models;

namespace ProductInfoService.Data.Interfaces;

public interface IProductRepository
{
    Product GetProductById(int id);
}

