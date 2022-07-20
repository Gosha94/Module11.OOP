using BankA.ConsultantSystem.DomainLogic.Models;
using BankA.ConsultantSystem.DomainLogic.Models.Base;

namespace BankA.ConsultantSystem.Console.Controllers;

    /// <summary>
    /// Контроллер консоли Банка
    /// </summary>
internal class BankConsoleController
{

    internal static void Greeting()
    {
        System.Console.WriteLine("Добро пожаловать в систему Банк А!");
    }

    internal static Employee GetEmployeeType()
    {
        System.Console.WriteLine("Выберите сотрудника, работающего с системой:");
        System.Console.WriteLine("1-Менеджер 2-Консультант");
        
        int inputEmployeeType;
        var isParseSuccess = int.TryParse(System.Console.ReadLine(), out inputEmployeeType);

        if (isParseSuccess)
        {
            if (inputEmployeeType == 1)
            {
                return new Manager("Peter", 100);
            }
            if (inputEmployeeType == 2)
            {
                return new Consultant("Ivan", 200);
            }

            return null;
        }
        else
        {
            return null;
        }
    }

    internal static bool GoExit()
    {
        System.Console.WriteLine("Для выхода нажмите X");
        var input = System.Console.ReadKey();
        
        return input.Key == ConsoleKey.X;
    }

    internal static void InputError()
    {
        System.Console.WriteLine("Некорректное значение ввода, повторите пожалуйста!");
    }

    #region Private Methods

    

    #endregion   

}