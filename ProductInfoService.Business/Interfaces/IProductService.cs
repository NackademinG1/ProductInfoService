using ProductInfoService.Models;

namespace ProductInfoService.Business.Interfaces;

public interface IProductService
{
    Product GetProductById(int id);
}

