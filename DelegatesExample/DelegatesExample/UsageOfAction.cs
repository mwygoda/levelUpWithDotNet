using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
