namespace _00_ConsoleApp.Interfaces;

internal interface IEmployee : IBaseEmployee
{
    IBaseEmployee Manager { get; set; }
}
