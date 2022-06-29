using System;
using System.Collections.Generic;


namespace GPAcalculation.Core
{
    public class PrintGPA
    {
        public static void print(List<Result> record, int twpt)
        {
            int num1 = 0;
            foreach (Result result in record)
                num1 += result.courseUnit;
            int num2 = 0;
            foreach (Result result in record)
                num2 += result.gradeUnit;
            Console.WriteLine();
            Console.WriteLine("Total Course Unit Registered is " + num1.ToString());
            Console.WriteLine("Total Course Unit Passed is " + num2.ToString());
            Console.WriteLine("Total Weight Point is " + twpt.ToString());
            Console.WriteLine("Your GPA is = " + string.Format("{0:0.##}", (object)((double)twpt / (double)num1)));
        }
    }
}
