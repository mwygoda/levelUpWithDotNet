using System;
using DelegatesExample.Delegates;
using DelegatesExample.EmployeeFramework.EmployeeServices;
using DelegatesExample.EmployeeFramework.Model;

namespace DelegatesExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var johnKowalski = new EmployeeModel
            {
                Age = 35,
                FirstName = "John",
                LastName = "Kowalski",
                Profession = "Coding Knight"
            };
            var introductors = new EmployeeIntroductor();
            var usageOfFunc = new UsageOfFunc();
            var customIntroduction = new CustomDelegate();
            var actionIndroduction = new UsageOfAction();
            Func<EmployeeModel, string> firstnameHandler = usageOfFunc.GetEmployeeFirstname;
            Action<EmployeeModel> actionHandler = introductors.CallByFirstName;

            Console.WriteLine("Using Custom Delegate");
            CustomDelegate.EmployeeIntroductionCustomHandler customHandler = introductors.CallByFirstName;
            customHandler += introductors.CallByLastName;
            customHandler += introductors.ShowTheProfession;
            customHandler += ShowAgeOfEmployee;
            customIntroduction.CustomIntroduct(johnKowalski, customHandler);

            Console.WriteLine("Using Action Delegate");
            actionHandler += introductors.CallByLastName;
            actionHandler += introductors.ShowTheProfession;
            actionHandler += ShowAgeOfEmployee;
            actionIndroduction.ActionIntroduct(johnKowalski, actionHandler);

            Console.WriteLine("Getting Name by Func");
            Console.WriteLine(firstnameHandler(johnKowalski));

            Console.WriteLine("Press any key ...");
            Console.ReadLine();
        }

        //New Function NOT included to framework.
        private static void ShowAgeOfEmployee(EmployeeModel employee)
        {
            Console.WriteLine(employee.Age);
        }
    }
}