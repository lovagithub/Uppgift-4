using _00_ConsoleApp.Interfaces;

namespace _00_ConsoleApp.Models.AbstractModels;

internal abstract class BaseEmployee : IBaseEmployee
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}
