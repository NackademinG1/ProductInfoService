using System.Collections.Generic;

namespace ProductInfoService.Models;

public class Product
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string StockStatus { get; set; }
    public List<string> Images { get; set; }
}

