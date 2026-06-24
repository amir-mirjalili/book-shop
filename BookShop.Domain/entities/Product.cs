using BookShop.Domain.Common;
namespace BookShop.Domain.entities;

public class Product: BaseEntity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
}
