using BankA.ConsultantSystem.DomainLogic.DTO;
using BankA.ConsultantSystem.DomainLogic.Models;

namespace BankA.ConsultantSystem.DomainLogic.Contracts
{

    /// <summary>
    /// Интерфейс разрешает добавлять запись Новый Клиент
    /// </summary>
    public interface IClientsCreator
    {
        /// <summary>
        /// Метод создания Клиента
        /// </summary>
        public Client CreateClient(NewClientPersonalDataDTO personalData);
    }
}
