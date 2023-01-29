using _00_ConsoleApp.Interfaces;
using _00_ConsoleApp.Models.AbstractModels;

namespace _00_ConsoleApp.Models;

internal class PrivateCustomer : Customer, IPrivateCustomer
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}
