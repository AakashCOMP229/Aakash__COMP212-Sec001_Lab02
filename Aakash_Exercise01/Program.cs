using System;

namespace Aakash_Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring built-in delegate- Func<> with three input arugment and one string return type
            //calling minimum method via Func<string, string, string, string> minStringFunc
            Func<string, string, string, string> minStringFunc = Minimum;
            Console.WriteLine($"Using a Func<>, a built-in delegate template:\nSmallest of three string values: {minStringFunc("Hello world", "Hello world there", "Two")}");

            //declaring built-in delegate- Action<> with three input arugment and no return type            
            Action<int, int, int> AvgGrade = Average;
            //calling Average method via Action<int, int, int> AvgGrade
            AvgGrade(5,10,15);
        }

        //Average method
        //to display average of three grades
        private static void Average(int arg1, int arg2, int arg3)
        {
            Console.WriteLine("\nUsing a Action, a built-in delegate template:\nAverage of three grades: " + (arg1+arg2+arg3)/3);
        }

        //Minimum method
        //to return the smallest of three string values. 
        private static string Minimum(string string1, string string2, string string3)
        {
            string minimumStringValue, minValue;
            minValue = string1.Length < string2.Length ? string1 : string2;
            minimumStringValue = minValue.Length < string3.Length ? minValue : string3;
            return minimumStringValue;
        }
    }
}
