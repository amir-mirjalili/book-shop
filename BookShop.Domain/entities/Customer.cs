using BookShop.Domain.Common;
namespace BookShop.Domain.entities;

public class Customer: BaseEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }

    public ICollection<Order> Orders { get; init; } = [];
}
