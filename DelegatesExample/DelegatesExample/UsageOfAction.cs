using System;

namespace DelegatesExample
{
    public class UsageOfAction
    {
        public void ActionIntroduct(EmployeeModel employee, Action<EmployeeModel> introductionHandler)
        {
            introductionHandler(employee);
        }
    }
}