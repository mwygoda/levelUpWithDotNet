using System;
using System.Dynamic;
using System.Runtime.InteropServices;

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
            var customIntroduction = new CustomDelegate();
            var introductors = new EmployeeIntroductor();
            CustomDelegate.EmployeeIntroductionCustomHandler customHandler = introductors.CallByFirstName;
            customHandler += introductors.CallByLastName;
            customHandler += introductors.ShowTheProfession;
            //new defined function
            customHandler += ShowAgeOfEmployee;
            customIntroduction.CustomIntroduct(johnKowalski, customHandler);

            Console.WriteLine("Press any key ...");
            Console.ReadLine();
        }

        static void ShowAgeOfEmployee(EmployeeModel employee)
        {
            Console.WriteLine(employee.Age);
        }
    }
}