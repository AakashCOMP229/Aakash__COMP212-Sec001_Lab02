using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aakash_Exercise01
{
    class Program
    {
        // declaring a delegate
        // delegate for a function which returns the smallest of three string values.
        //
               public delegate string Minimum(string string1, string string2, string string3);
        static void Main(string[] args)
        {
            Func<string, string, string, string> minStringFunc = MinimumV;
            Console.WriteLine($"Using a built-in delegate template- Minimum call : {minStringFunc("Hello world", "Hello world there", "Hello world threeeeee")}");
        }

        private static string MinimumV(string string1, string string2, string string3)
        {
            string miniValue, minValue = default;
            minValue = string1.Length < string2.Length ? string1 : string2;
            miniValue = minValue.Length < string3.Length ? minValue : string3;
            return miniValue;
        }
    }
}
