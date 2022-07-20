using BankA.ConsultantSystem.DomainLogic.DTO;

namespace BankA.ConsultantSystem.DomainLogic.Models;

/// <summary>
/// Модель Клиент Банка
/// </summary>
public class Client
{
    private string _lastName = string.Empty;
    private string _firstName = string.Empty;
    private string _middleName = string.Empty;
    private string _phoneNumber = string.Empty;
    private string _passportSerNumb = string.Empty;
    
    private DateTime _changeDt;
    private string _whichPropertyChanged = string.Empty;
    private string _whoMadeChanges = string.Empty;

    public Client()
    { }

    private Client(string lastName, string firstName, string middleName, string phoneNumber, string passSerialNumb)
    {
        _lastName = lastName;
        _firstName = firstName;
        _middleName = middleName;
        _phoneNumber = phoneNumber;
        _passportSerNumb = passSerialNumb;
    }

    #region Public Properties
    
    public string LastName { get => _lastName; }
    public string FirstName { get => _firstName; }
    public string MiddleName { get => _middleName; }
    public string PhoneNumber { get => _phoneNumber; }
    public string PassportSerialWithNumber { get => _passportSerNumb; }

    public DateTime ChangeDt { get => _changeDt;}
    public string WhichPropertyChanged { get => _whichPropertyChanged;}
    public string WhoMadeChanges { get => _whoMadeChanges;}

    #endregion
    
    #region Public Methods

    public static Client Create(NewClientPersonalDataDTO newClientDTO)
    {
        return new Client(newClientDTO.LastName, newClientDTO.FirstName, newClientDTO.MiddleName, newClientDTO.PhoneNumber, newClientDTO.PassportSerNumb);
    }

    public static NewClientPersonalDataDTO ConvertFrom(Client client)
    {
        return new NewClientPersonalDataDTO
        {
            LastName = client.LastName,
            FirstName = client.FirstName,
            MiddleName = client.MiddleName,
            PhoneNumber = client.PhoneNumber,
            PassportSerNumb = client.PassportSerialWithNumber
        };
    }

    public void SetLastName(string newLastName, string dataChanger)
    {
        _lastName = newLastName;
        ChangeProperty(nameof(this.LastName), dataChanger);
    }

    public void SetFirstName(string newFirstName, string dataChanger)
    {
        _firstName = newFirstName;
        ChangeProperty(nameof(this.FirstName), dataChanger);
    }

    public void SetMiddleName(string newMiddleName, string dataChanger)
    {
        _middleName = newMiddleName;
        ChangeProperty(nameof(this.MiddleName), dataChanger);
    }

    public void SetPhoneNumber(string newPhoneNumber, string dataChanger)
    {
        if (string.IsNullOrEmpty(newPhoneNumber))
        {
            throw new ArgumentException("Поле 'Номер телефона' обязательно для заполнения у Клиента!");
        }
        else
        {
            _phoneNumber = newPhoneNumber;
            ChangeProperty(nameof(this.PhoneNumber), dataChanger);
        }
    }

    public void SetPassportData(string newPassportData, string dataChanger)
    {
        _passportSerNumb = newPassportData;
        ChangeProperty(nameof(this.PassportSerialWithNumber), dataChanger);
    }

    #endregion

    #region Private Method

    private void ChangeProperty(string whichProperty, string whoChange)
    {
        _changeDt = DateTime.Now;
        _whichPropertyChanged = whichProperty;
        _whoMadeChanges = whoChange;
    }

    #endregion

}