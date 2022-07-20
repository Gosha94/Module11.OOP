using BankA.ConsultantSystem.DomainLogic.DTO;
using BankA.ConsultantSystem.DomainLogic.Contracts;

namespace BankA.ConsultantSystem.DomainLogic.Models
{

    /// <summary>
    /// Модель Менеджер
    /// </summary>
    public class Manager : Consultant, IClientsCreator, IClientsEditor
    {

        public Manager(string name, int salary) : base(name, salary)
        { }

        public bool EditFirstName(Client client, string newFirstName)
        {
            client.SetFirstName(newFirstName, nameof(Manager));
            return true;
        }

        public bool EditLastName(Client client, string newLastName)
        {
            client.SetLastName(newLastName, nameof(Manager));
            return true;
        }

        public bool EditMiddleName(Client client, string newMiddleName)
        {
            client.SetMiddleName(newMiddleName, nameof(Manager));
            return true;
        }

        public bool EditPassportData(Client client, string newPassportData)
        {
            client.SetPassportData(newPassportData, nameof(Manager));
            return true;
        }

        public Client CreateClient(NewClientPersonalDataDTO personalData)
        {
            return Client.Create(personalData);
        }
    }
}