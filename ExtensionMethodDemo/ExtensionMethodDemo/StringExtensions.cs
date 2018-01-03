using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    public static class StringExtensions
    {
        public static string ChangeFirstLetterToSeven(this string @this)
        {
            if (@this.Length > 0)
            {
                var charArray = @this.ToCharArray();
                charArray[0] = '7';
                return new string(charArray);
            }
            return @this;
        }
    }
}
