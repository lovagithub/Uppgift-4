using _00_ConsoleApp.Interfaces;
using _00_ConsoleApp.Models;
using Newtonsoft.Json;

namespace _00_ConsoleApp.Services;

internal class Menu
{
    private List<ICustomer> customers = new List<ICustomer>();
    private List<IBaseEmployee> employees = new List<IBaseEmployee>();
    private FileService file = new FileService();

    public string FilePath { get; set; } = null!;

    public void WelcomeMenu()
    {
        Console.Clear();
        Console.WriteLine("ADMINISTRATIONSAPPLIKATIONEN");
        Console.WriteLine("1. Lägg till en ny kund.");
        Console.WriteLine("2. Lägg till en ny anställd.");
        Console.WriteLine("3. Visa alla kunder.");
        Console.WriteLine("4. Visa alla anställda");
        Console.Write("Ange ett av alternativen ovan: ");
        var option = Console.ReadLine();

        switch(option)
        {
            case "1": OptionOne(); break;
            case "2": OptionTwo(); break;
            case "3": OptionThree(); break;
            case "4": OptionFour(); break;
        }
    }

    private void OptionOne()
    {
        Console.Clear();
        Console.WriteLine("Lägg till en ny kund.");
        Console.WriteLine("1. Företagskund");
        Console.WriteLine("2. Privatkund");
        Console.Write("Välj vad för typ av kund du vill skapa: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1": CreateBusinessCustomer(); break;
            case "2": CreatePrivateCustomer(); break;
        }

        file.Save(FilePath, JsonConvert.SerializeObject(new { customers, employees }));
    }

    private void CreateBusinessCustomer()
    {
        Console.Clear();
        Console.WriteLine("Lägg till en ny företagskund.");

        IBusinessCustomer customer = new BusinessCustomer();
        Console.Write("Ange Organisationsnummer: ");
        customer.OrganizationNumber = Console.ReadLine() ?? "";
        Console.Write("Ange Företagsnamn: ");
        customer.CompanyName = Console.ReadLine() ?? "";
        Console.Write("Ange Företagsadress: ");
        customer.Address = Console.ReadLine() ?? "";
        Console.Write("Ange Telefonnummer: ");
        customer.Phone = Console.ReadLine() ?? "";
        Console.Write("Ange E-postadress: ");
        customer.Email = Console.ReadLine() ?? "";
        Console.Write("Ange Kontaktperson: ");
        customer.ContactPerson = Console.ReadLine() ?? "";

        customers.Add(customer);
    }
    private void CreatePrivateCustomer()
    {
        Console.Clear();
        Console.WriteLine("Lägg till en ny privatkund.");

        IPrivateCustomer customer = new PrivateCustomer();
        Console.Write("Ange Förnamn: ");
        customer.FirstName = Console.ReadLine() ?? "";
        Console.Write("Ange Efternamn: ");
        customer.LastName = Console.ReadLine() ?? "";
        Console.Write("Ange Adress: ");
        customer.Address = Console.ReadLine() ?? "";
        Console.Write("Ange Telefonnummer: ");
        customer.Phone = Console.ReadLine() ?? "";
        Console.Write("Ange E-postadress: ");
        customer.Email = Console.ReadLine() ?? "";

        customers.Add(customer);
    }



    private void OptionTwo()
    {
        Console.Clear();
        Console.WriteLine("Lägg till en ny anställd.");
        Console.WriteLine("1. VD");
        Console.WriteLine("2. Ekonomichef");
        Console.WriteLine("3. Assistent");
        Console.WriteLine("4. Key Account Manager");
        Console.Write("Välj vad för typ av anställd du vill skapa: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1": CreateCEO(); break;
            case "2": CreateCFO(); break;
            //case "3": CreateAssistant(); break;
            //case "4": CreateKeyAccountManager(); break;
        }
    }

    private void CreateCEO()
    {
        Console.Clear();
        Console.WriteLine("Lägg till en ny VD");

        ICEO employee = new CEO();
        Console.Write("Ange Förnamn: ");
        employee.FirstName = Console.ReadLine() ?? "";
        Console.Write("Ange Efternamn: ");
        employee.LastName = Console.ReadLine() ?? "";
        Console.Write("Är personen en verklig huvudman? (y/n) ");
        var answer = Console.ReadLine();
        employee.BenificialOwner = (answer?.ToLower() == "y");

        employees.Add(employee);
    }

    private void CreateCFO()
    {
        Console.Clear();
        Console.WriteLine("Lägg till en ny Ekonomichef");

        ICFO employee = new CFO();
        Console.Write("Ange Förnamn: ");
        employee.FirstName = Console.ReadLine() ?? "";
        Console.Write("Ange Efternamn: ");
        employee.LastName = Console.ReadLine() ?? "";
        Console.Write("Ange e-postadressen på den anställdes chef: ");
        var email = Console.ReadLine();
        var manager = employees.FirstOrDefault(x => x.Email == email);
        if (manager != null)
        {
            employee.Manager= manager;
        }
        
        employees.Add(employee);
    }














    private void OptionThree()
    {

    }

    private void OptionFour()
    {

    }
}
