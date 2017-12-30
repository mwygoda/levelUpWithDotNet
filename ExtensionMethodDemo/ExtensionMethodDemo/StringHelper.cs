using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    public static class StringHelper
    {
        public static string ChangeFirstLetterToSeven(this string inputString)
        {
            if (inputString.Length > 0)
            {
                var charArray = inputString.ToCharArray();
                charArray[0] = '7';
                return new string(charArray);
            }
            return inputString;
        }
    }
}
