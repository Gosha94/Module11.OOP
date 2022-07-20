using BankA.ConsultantSystem.DomainLogic.Models;

namespace BankA.ConsultantSystem.DomainLogic.Contracts
{

    /// <summary>
    /// Интерфейс разрешает редактирование данных Клиента
    /// </summary>
    public interface IClientsEditor
    {
        public bool EditFirstName(Client client, string newFirstName);


        public bool EditLastName(Client client, string newLastName);


        public bool EditMiddleName(Client client, string newMiddleName);


        public bool EditPassportData(Client client, string newPassportData);

        public bool EditPhoneNumber(Client client, string newPhoneNumber);

    }
}
