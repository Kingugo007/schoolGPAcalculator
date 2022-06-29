using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace GPAcalculation.Core
{
    public class AddResults
    {
        private List<Result> students = new List<Result>();

        // COURSE UNIT VALIDATION
        public static int validUnit()
        {
            int result;
            while (true)
            {
                Console.Write("Enter Your Course Unit: ");
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    if (result > 5)
                        Console.WriteLine("Invalid course unit: Your courses unit are less than 5");
                    else if (result < 0)
                        Console.WriteLine("Invalid course unit: Can not have a negative course unit");
                    else
                        break;
                }
                else
                    Console.WriteLine("ERROR: Enter only numbers");
            }
            return result;
        }

        // COURSE SCORE VALIDATION
        public static double validScore()
        {
            double result;
            while (true)
            {
                Console.Write("Enter Your Score: ");
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    if (result > 100.0)
                        Console.WriteLine("Not a valid score: Your examination score should be less than 100");
                    else if (result < 0.0)
                        Console.WriteLine("Not a valid score: Cannot have a negative score input");
                    else
                        break;
                }
                else
                    Console.WriteLine("ERROR: Enter only numbers");
            }
            return result;
        }

        // COURSE NAME VALIDATION
        public static string validCourseName()
        {
            bool flag = true;
            string input;
            do
            {
                Console.Write("Enter Your Course Name and Code: ");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    Console.WriteLine("ERROR: Course code must not be empty");
                else if (input.Length == 1)
                    Console.WriteLine("Invalid Course name: Enter a valid course code E.g MTH101");
                else if (input.Length == 2)
                    Console.WriteLine("Invalid Course name: Enter a valid course code E.g MTH101");
                else if (input.Length >= 3)
                {
                    if (!Regex.IsMatch(input, "^[a-zA-Z0-9]+$"))
                        Console.WriteLine("ERROR: Course and code should be alphaNumeric E.g MTH101");
                    else
                        break;
                }
            }
            while (flag);
            return input;
        }

        // ADDING RESULTS FOR CALCULATIONS
        public void addCourse()
        {
            while (true)
            {
                Console.WriteLine("Enter Your Examination Results: ");
                Console.WriteLine("NOTE: Enter two (2) courses and above to calculate your current GPA");
                while (true)
                {
                    Console.WriteLine("Enter Course details");
                    this.students.Add(new Result(AddResults.validCourseName(), AddResults.validUnit(), AddResults.validScore(), string.Empty, 0, char.MinValue, 0));
                    Console.WriteLine();
                    if (this.students.Count >= 2)
                    {
                        Console.WriteLine("Enter \"y\" to see GPA or press enter to continue adding results");
                        if (Console.ReadLine().ToLower() == "y")
                            break;
                    }
                }

                // PASSING STUDENT RESULT TO RESULT CALCULATOR CLASS
                ResultCalculator.calWeightPt(this.students);

                // ASK FOR ANOTHER USER RESULT DETAILS
                Console.WriteLine();
                Console.WriteLine("Enter \"y\" to Calculate another student GPA Or Enter key to exit");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.Clear();
                    this.students.Clear();
                }
                else
                    break;
            }
        }
    }
}
