using DelegatesExample.EmployeeFramework.Model;

namespace DelegatesExample.Delegates
{
    public class UsageOfFunc
    {
        public string GetEmployeeFirstname(EmployeeModel employee)
        {
            return employee.FirstName;
        }
    }
}