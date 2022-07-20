using Newtonsoft.Json;
using BankA.ConsultantSystem.Console.JsonParser;
using BankA.ConsultantSystem.Console.Controllers;
using BankA.ConsultantSystem.DomainLogic.Models;
using BankA.ConsultantSystem.DomainLogic.DTO;

var pathToClientsJson = "Resources/BankClients.json";
var clientsDataStr = File.ReadAllText(pathToClientsJson);

var bankClientsRoot = JsonConvert.DeserializeObject<Root>(clientsDataStr);
var bankClients = bankClientsRoot.Clients;

var isExitRequired = false;

while (!isExitRequired)
{
    BankConsoleController.Greeting();

    var employee = BankConsoleController.GetEmployeeType();
    
    if (employee == null)
    {
        BankConsoleController.InputError();
    }    
    else if (employee is Manager)
    {
        var manager = employee as Manager;
        if (manager != null)
        {
            var newClientData = new NewClientPersonalDataDTO
            {
                FirstName = "Some",
                LastName = "Some",
                MiddleName = "Some",
                PassportSerNumb = "0000111111",
                PhoneNumber = "70000000000"
            };
            var newClient = manager.CreateClient(newClientData);
            bankClients.Add(Client.ConvertFrom(newClient));
        }
    }
    else if (employee is Consultant)
    {
        var consultant = employee as Consultant;
        Console.WriteLine("Паспортные данные клиентов:");
        bankClients.ForEach(clientDto =>
        {
            var client = Client.Create(clientDto);
            var passData = consultant.GetPassportData(client);
            Console.WriteLine($"{passData}");
        });
    }

    isExitRequired = BankConsoleController.GoExit();
}