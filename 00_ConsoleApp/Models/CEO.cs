using _00_ConsoleApp.Interfaces;
using _00_ConsoleApp.Models.AbstractModels;

namespace _00_ConsoleApp.Models;


internal class CEO : BaseEmployee, ICEO
{
    public bool BenificialOwner { get; set; } = true;
}
