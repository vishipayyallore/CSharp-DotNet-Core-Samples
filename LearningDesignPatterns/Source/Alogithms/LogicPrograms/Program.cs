using LogicPrograms.Interfaces;
using LogicPrograms.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using Math = LogicPrograms.Logics.Math;

namespace LogicPrograms
{

    class Result
    {
        public static List<int> gradingStudents(List<int> grades)
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

    class Program
    {
        static void Main(string[] args)
        {

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades);

            // Grading Students
            GradingStudents();

            // Time Conversion
            TimeConversion();

            // Candles Count
            var candlesCount = BirthdayCandles();
            WriteLine($"Count: {candlesCount}");

            MinMaxInArray();

            GeneralPrograms generalPrograms = new GeneralPrograms();
            generalPrograms.DisplayStairCase(10);

            // Stair Case Program
            var number1 = 4;
            for (var index = 1; index <= number1; index++)
            {
                WriteLine(string.Concat(Enumerable.Repeat("#", index)).PadLeft(number1));
            }


            IMonthNames monthNames = new MonthNames();

            for (var counter = 1; counter <= 10; counter++)
            {
                monthNames.DisplayMonthNames();
            }

            //------------------------------------------------------------------------------------------
            var arrayItems = new int[] { 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 0, 0 };

            var left = 0;
            var right = arrayItems.Length - 1;
            for (var index = 0; index < arrayItems.Length; index++)
            {
                if (arrayItems[left] > arrayItems[right])
                {
                    var temp = arrayItems[left];
                    arrayItems[left] = arrayItems[right];
                    arrayItems[right] = temp;
                    left++;
                    right--;
                }
            }

            ISortBinaryArray sortBinaryArray = new SortBinaryArray();
            sortBinaryArray.SortArray(arrayItems);
            //------------------------------------------------------------------------------------------

            //------------------------------------------------------------------------------------------
            IMath math = new Math();

            Write("\n\nEnter a number for finding Factorial: ");

            if (int.TryParse(ReadLine(), out int number))
            {
                var factorial = math.GetFactorial(number);
                WriteLine($"Factorial: {factorial}");
            }
            //------------------------------------------------------------------------------------------

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        private static void GradingStudents()
        {
            var students = int.Parse(ReadLine());
            var grades = new int[students];
            for (var i = 0; i < students; i++)
            {
                var grade = int.Parse(ReadLine());

                if (grade < 38)
                {
                    grades[i] = grade;
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
                        grades[i] = grade + balance;
                    }
                    else
                    {
                        grades[i] = grade;
                    }
                }
            }
        }

        private static void TimeConversion()
        {
            var time12 = "07:05:45PM";
            // var timePart = Array.ConvertAll(time12.Substring(0, 8).Split(":"), item => int.Parse(item));
            var timePart = Array.ConvertAll(time12.Substring(0, 8).Split(":"), int.Parse);
            var amPm = time12.Substring(8);

            if (amPm == "AM")
            {
                if (timePart[0] == 12)
                {
                    timePart[0] = 0;
                }
            }
            else if (amPm == "PM")
            {
                if (timePart[0] < 12)
                {
                    timePart[0] += 12;
                }
            }

            WriteLine($"{timePart[0]:00}:{timePart[1]:00}:{timePart[2]:00}");
        }

        private static int BirthdayCandles()
        {
            int[] array = { 3, 5, 2, 5, 1, 3, 5 };
            int maxNumber = array[0];
            int maxNumberCount = 0;

            for(var index=0; index < array.Length; index++)
            {
                if(maxNumber < array[index])
                {
                    maxNumber = array[index];
                    maxNumberCount = 1;
                }
                else if(maxNumber == array[index])
                {
                    maxNumberCount++;
                }
            }

            return maxNumberCount;
        }

        private static void MinMaxInArray()
        {
            int[] array1 = { 1, 3, 5, 7, 9 };
            int min = 0, max = 0;

            for (int index = 0; index < array1.Length; index++)
            {
                var current = array1.Sum() - array1[index];

                if (index == 0)
                {
                    min = max = current;
                }
                else
                {
                    if (current > max)
                    {
                        max = current;
                    }
                    else if (current <= min)
                    {
                        min = current;
                    }
                }
                WriteLine(array1.Sum() - array1[index]);
            }
            WriteLine($"{min} {max}");
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