using _00_ConsoleApp.Interfaces;

namespace _00_ConsoleApp.Models.AbstractModels;

internal abstract class Employee : BaseEmployee, IEmployee
{
    public IBaseEmployee Manager { get; set; } = null!;
}
