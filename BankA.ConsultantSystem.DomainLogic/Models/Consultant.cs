using BankA.ConsultantSystem.DomainLogic.Models.Base;

namespace BankA.ConsultantSystem.DomainLogic.Models
{

    /// <summary>
    /// Модель Консультант
    /// </summary>
    public class Consultant : Employee
    {

        public Consultant(string name, int salary): base(name, salary)
        {   }

        public bool EditPhoneNumber(Client client, string newPhoneNumber)
        {
            client.SetPhoneNumber(newPhoneNumber, nameof(Consultant));
            return true;
        }

    }
}