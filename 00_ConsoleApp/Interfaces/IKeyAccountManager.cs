namespace _00_ConsoleApp.Interfaces;

internal interface IKeyAccountManager : IEmployee
{
    List<ICustomer> Customers { get; set; }
}
