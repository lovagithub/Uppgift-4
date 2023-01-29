using _00_ConsoleApp.Interfaces;

namespace _00_ConsoleApp.Models.AbstractModels;

internal abstract class Customer : ICustomer
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Address { get; set; } = null!;

}
