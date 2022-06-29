using GPAcalculation.UI;
using System.Collections.Generic;


namespace GPAcalculation.Core
{
    public class ResultCalculator
    {
        public static void calWeightPt(List<Result> record)
        {
            int twpt = 0;
            foreach (Result result1 in record)
            {
                if (result1.courseScore >= 70.0)
                {
                    twpt = result1.courseUnit * 5 + twpt;
                    result1.weightPt = result1.courseUnit * 5;
                    result1.grade = 'A';
                    result1.remark = "Excellent";
                    result1.gradeUnit = 5;
                }
                else if (result1.courseScore >= 60.0 && result1.courseScore <= 69.0)
                {
                    twpt = result1.courseUnit * 4 + twpt;
                    result1.weightPt = result1.courseUnit * 4;
                    result1.grade = 'B';
                    result1.remark = "Very Good";
                    result1.gradeUnit = 4;
                }
                else if (result1.courseScore >= 50.0 && result1.courseScore <= 59.0)
                {
                    twpt = result1.courseUnit * 3 + twpt;
                    result1.weightPt = result1.courseUnit * 3;
                    result1.grade = 'C';
                    result1.remark = "Good";
                    result1.gradeUnit = 3;
                }
                else if (result1.courseScore >= 45.0 && result1.courseScore <= 49.0)
                {
                    twpt = result1.courseUnit * 2 + twpt;
                    result1.weightPt = result1.courseUnit * 2;
                    result1.grade = 'D';
                    result1.remark = "Fair";
                    result1.gradeUnit = 2;
                }
                else if (result1.courseScore >= 40.0 && result1.courseScore <= 44.0)
                {
                    twpt = result1.courseUnit + twpt;
                    result1.weightPt = result1.courseUnit;
                    result1.grade = 'E';
                    result1.remark = "Pass";
                    result1.gradeUnit = 1;
                }
                else if (result1.courseScore >= 0.0 && result1.courseScore <= 39.0)
                {
                    int courseUnit1 = result1.courseUnit;
                    twpt = 0 + twpt;
                    Result result2 = result1;
                    int courseUnit2 = result1.courseUnit;
                    result2.weightPt = 0;
                    result1.grade = 'F';
                    result1.remark = "Fail";
                    result1.gradeUnit = 0;
                }
            }
            PrintTable.print(record, twpt);
            PrintGPA.print(record, twpt);
        }
    }
}
