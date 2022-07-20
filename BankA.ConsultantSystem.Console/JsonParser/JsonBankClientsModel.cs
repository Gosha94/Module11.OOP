using BankA.ConsultantSystem.DomainLogic.DTO;

namespace BankA.ConsultantSystem.Console.JsonParser
{

    /// <summary>
    /// Модель для считывания данных из файла BankClients.json
    /// </summary>
    internal class Root
    {
        public List<NewClientPersonalDataDTO> Clients { get; set; }
    }

}
