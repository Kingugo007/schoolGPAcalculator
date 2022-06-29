using GPAcalculation.Core;
using System;
using System.Collections.Generic;


#nullable enable
namespace GPAcalculation.UI
{
    public class PrintTable
    {
        public static void print(List<Result> record, int twpt)
        {
            Console.WriteLine("|--------------|------------|------|-----------|-----------|----------------|");
            Console.WriteLine("|COURSE & CODE |COURSE UNIT |GRADE |GRADE-UNIT |WEIGHT Pt. |REMARK          |");
            Console.WriteLine("|--------------|------------|------|-----------|-----------|----------------|");
            foreach (Result result in record)
                Console.WriteLine("|{0,-14}|{1,-12}|{2,-6}|{3,-11}|{4,-11}|{5,-16}|", (object)result.courseCode, (object)result.courseUnit, (object)result.grade, (object)result.gradeUnit, (object)result.weightPt, (object)result.remark);
            Console.WriteLine("|--------------|------------|------|-----------|-----------|----------------|");
        }
    }
}
