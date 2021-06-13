using System;

namespace Aakash_Exercise02
{
    class Program
    {
        // declaring a delegate
        // delegate for a function that receives an double and returns a bool
        public delegate bool GradesPredicate(double numbers);
        static void Main(string[] args)
        {
            double[] gradesArray = { 40.25, 52.35, 34.50, 64.30, 75.15, 86.23, 77.44, 58.33, 39.24, 90.95 };

            GradesPredicate gradesPredicate = numbersOver50 => numbersOver50 >= 50;
            GradesFilter(gradesArray, gradesPredicate);
        }

        //displays only those grades values which are greater than or equal to 50
        public static void GradesFilter(double[] grades, GradesPredicate gradesPredicate)
        {
            Console.WriteLine("Grades over 50 are as follows: ");
            // iterate over each element in the array
            foreach (var item in grades)
            {
                // if the element satisfies the predicate
                if (gradesPredicate(item))
                {
                    Console.WriteLine(item);
                }
            }            
        }
    }
}
