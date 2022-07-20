namespace BankA.ConsultantSystem.DomainLogic.Models.Base
{

    /// <summary>
    /// Модель Сотрудник Банка
    /// </summary>
    public abstract class Employee
    {

        private readonly string _name;
        private readonly int _salary;

        public Employee(string name, int salary)
        {
            _name = name;
            _salary = salary;
        }

        public virtual string GetPassportData(Client client)
        {
            if (!string.IsNullOrEmpty(client.PassportSerialWithNumber))
            {
                return "******************";
            }
            else
            {
                return string.Empty;
            }
        }

        public virtual string GetFirstName(Client client) => client.FirstName;

        public virtual string GetMiddleName(Client client) => client.MiddleName;

        public virtual string GetLastName(Client client) => client.LastName;

    }
}