using System.Collections.Generic;

namespace LogicPrograms
{
    public class GradingResult
    {
        public static List<int> GradingStudents(List<int> grades)
        {
            var grades_output = new List<int>();

            for (var i = 0; i < grades.Count; i++)
            {
                var grade = grades[i];

                if (grade < 38)
                {
                    grades_output.Add(grade);
                }
                else
                {
                    var reminder = grade % 10;
                    var balance = 0;
                    if (reminder >= 1 && reminder < 5)
                    {
                        balance = 5 - reminder;
                    }
                    else if (reminder >= 6 && reminder < 10)
                    {
                        balance = 10 - reminder;
                    }

                    if (balance < 3)
                    {
                        grades_output.Add(grade + balance);
                    }
                    else
                    {
                        grades_output.Add(grade);
                    }
                }
            }

            return grades_output;
        }

    }


    

}


//static Int64 GetSum(int[] array1)
//{
//    Int64 sum = 0;
//    for (var index = 0; index < array1.Length; index++)
//    {
//        sum += array1[index];
//    }

//    return sum;
//}

//static void miniMaxSum(int[] array1)
//{
//    Int64 sum = GetSum(array1);
//    Int64 min = sum, max = 0;

//    for (int index = 0; index < array1.Length; index++)
//    {
//        Int64 current = sum - array1[index];

//        if (current > max)
//        {
//            max = current;
//        }
//        if (current < min)
//        {
//            min = current;
//        }
//    }
//    Console.WriteLine($"{min} {max}");
//}