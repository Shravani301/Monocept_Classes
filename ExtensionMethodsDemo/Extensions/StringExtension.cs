using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDemo.Extensions
{
    internal static class StringExtension
    {
        public static string ToSnakeCase(this string str)
        {
            string convertedString = "";
            foreach (char c in str)
            {
                if(c == ' ')
                    convertedString += "_";
                else 
                    convertedString += c;
            }
            return convertedString;
        }

    }
}
