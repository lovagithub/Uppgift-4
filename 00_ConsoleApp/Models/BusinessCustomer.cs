using _00_ConsoleApp.Interfaces;
using _00_ConsoleApp.Models.AbstractModels;

namespace _00_ConsoleApp.Models;

internal class BusinessCustomer : Customer, IBusinessCustomer
{
    public string OrganizationNumber { get; set; } = null!;
    public string CompanyName { get; set; } = null!;
    public string ContactPerson { get; set; } = null!;
}
