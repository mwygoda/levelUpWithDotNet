using System;

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
            var usageOfFunc = new UsageOfFunc();
            Func<EmployeeModel, string> firstnameHandler = usageOfFunc.GetEmployeeFirstname;
            var introductors = new EmployeeIntroductor();
            Console.WriteLine("Using Custom Delegate");
            var customIntroduction = new CustomDelegate();
            CustomDelegate.EmployeeIntroductionCustomHandler customHandler = introductors.CallByFirstName;
            customHandler += introductors.CallByLastName;
            customHandler += introductors.ShowTheProfession;
            //new defined function
            customHandler += ShowAgeOfEmployee;
            customIntroduction.CustomIntroduct(johnKowalski, customHandler);

            Console.WriteLine("Using Action Delegate");
            var actionIndroduction = new UsageOfAction();
            Action<EmployeeModel> actionHandler = introductors.CallByFirstName;
            actionHandler += introductors.CallByLastName;
            actionHandler += introductors.ShowTheProfession;
            actionHandler += ShowAgeOfEmployee;
            actionIndroduction.ActionIntroduct(johnKowalski, actionHandler);

            Console.WriteLine("Getting Name by Func");
            Console.WriteLine(firstnameHandler(johnKowalski));

            Console.WriteLine("Press any key ...");
            Console.ReadLine();
        }

        private static void ShowAgeOfEmployee(EmployeeModel employee)
        {
            Console.WriteLine(employee.Age);
        }
    }
}