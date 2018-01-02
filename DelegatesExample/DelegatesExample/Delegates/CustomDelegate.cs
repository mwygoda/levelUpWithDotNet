using DelegatesExample.EmployeeFramework.Model;

namespace DelegatesExample.Delegates
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
