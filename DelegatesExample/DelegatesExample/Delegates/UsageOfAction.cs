using System;
using DelegatesExample.EmployeeFramework.Model;

namespace DelegatesExample.Delegates
{
    public class UsageOfAction
    {
        public void ActionIntroduct(EmployeeModel employee, Action<EmployeeModel> introductionHandler)
        {
            introductionHandler(employee);
        }
    }
}