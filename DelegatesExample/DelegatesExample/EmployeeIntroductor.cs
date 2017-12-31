using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
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
