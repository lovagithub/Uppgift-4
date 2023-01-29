using _00_ConsoleApp.Interfaces;
using _00_ConsoleApp.Models.AbstractModels;

namespace _00_ConsoleApp.Models;

internal class KeyAccountManager : Employee, IKeyAccountManager
{
    public List<ICustomer> Customers { get; set; } = new List<ICustomer>();
}
