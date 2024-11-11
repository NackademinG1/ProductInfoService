using ProductInfoService.Domain;

namespace ProductInfoService.Business.Interfaces;

public interface IProductService
{
    Product GetProductById(int id);
}

