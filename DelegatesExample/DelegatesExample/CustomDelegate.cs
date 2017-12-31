using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class CustomDelegate
    {
        public delegate void EmployeeIntroductionCustomHandler(EmployeeModel employee);

        public void CustomIntroduct(EmployeeModel employee,EmployeeIntroductionCustomHandler introductionHandler)
        {
            introductionHandler(employee);
        }
    }
}
