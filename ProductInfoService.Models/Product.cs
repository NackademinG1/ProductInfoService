namespace ProductInfoService.Models;

public class Product
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public string StockStatus { get; set; } = string.Empty;
    public List<string> Images { get; set; } =new List<string>();
}

