using System;
using DelegatesExample.EmployeeFramework.Model;

namespace DelegatesExample.EmployeeFramework.EmployeeServices
{
    public class EmployeeIntroductor
    {
        public void CallByFirstName(EmployeeModel employee)
        {
            Console.WriteLine(employee.FirstName);
        }

        public void CallByLastName(EmployeeModel employee)
        {
            Console.WriteLine(employee.LastName);
        }

        public void ShowTheProfession(EmployeeModel employee)
        {
            Console.WriteLine(employee.Profession);
        }
    }
}
