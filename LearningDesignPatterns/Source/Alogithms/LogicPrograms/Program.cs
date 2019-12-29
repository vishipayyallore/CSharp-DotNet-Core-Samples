using LogicPrograms.Interfaces;
using LogicPrograms.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using Math = LogicPrograms.Logics.Math;

namespace LogicPrograms
{

    class Program
    {
        static void Main(string[] args)
        {

            // Beautiful Days at the Movies
            var ijk = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            var count = 0;

            for(var iCtr=ijk[0]; iCtr<=ijk[1]; iCtr++)
            {
                var rCtr = ReverseNumber(iCtr);

                var result = (iCtr - rCtr) / (ijk[2] * 1.0);

                if(System.Math.Abs(result)  % 1 == 0)
                {
                    count++;
                }
            }

            WriteLine(count);

            // Strong Password
            StrongPassword();

            // Mars Exploration
            MarsExploration();

            // Drawing Book
            DrawingBook();

            // Angry Professor
            AngryProfessor();

            // Utopian Tree
            UtopianTreeDemo();

            // Designer PDF Viewer
            PDFViewer();

            // For testing the reusable method (FindMaximumOfArrayWithItsIndex)
            var arr1 = new int[] { 0 };
            var results = FindMaximumOfArrayWithItsIndex(arr1);

            // The Hurdle Race
            TheHurdleRace();

            // Cats and a Mouse
            CatsAndMouse();

            // Electronics Shop
            ElectronicsShop();

            // Day Of Programmer
            DayOfProgrammerV2();

            DayOfProgrammerV1();

            // Bon Appétit
            BonAppetit();

            // Migratory Birds
            MigratoryBirds();

            // Birthday Chocolate
            BirthdayChocolate();

            // Divisible Sum Pairs
            DivisibleSumPairs();

            // Breaking The Records.
            BreakingTheRecords();

            // TODO: Complete the Algorithm
            // Kangaroo Jumps
            KangarooJumps();

            // Apples and Oranges
            AppleAndOrangesCount();

            AppleAndOrangesCountV2();

            AppleAndOrangesCountV3();

            // Library Fines
            LibraryFines();

            // Arrays: Left Rotation
            ArrayLeftRotation();

            // Grading Students
            GradingStudentsV1();

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

        private static int ReverseNumber(int value)
        {
            var reverse = 0;

            while(value > 0)
            {
                reverse = (reverse * 10) + (value%10);
                value /= 10;
            }

            return reverse;
        }

        private static void UtopianTreeDemo()
        {
            for (var n = 0; n <= 5; n++)
            {
                WriteLine(UtopianTreeV2(n));
            }

            for (var n = 0; n <= 5; n++)
            {
                WriteLine(UtopianTree(n));
            }
        }

        private static void StrongPassword()
        {
            // var password = "#HackerRank";
            var password = "Ab1";
            var passwordRequirement = new bool[] { false, false, false, false };
            const string numbers = "0123456789";
            const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string specialCharacters = "!@#$%^&*()-+";
            var required = 0;

            foreach (var character in password)
            {
                if (!passwordRequirement[0] && numbers.IndexOf(character) >= 0)
                {
                    passwordRequirement[0] = true;
                }
                else if (!passwordRequirement[1] && lowerCase.IndexOf(character) >= 0)
                {
                    passwordRequirement[1] = true;
                }
                else if (!passwordRequirement[2] && upperCase.IndexOf(character) >= 0)
                {
                    passwordRequirement[2] = true;
                }
                else if (!passwordRequirement[3] && specialCharacters.IndexOf(character) >= 0)
                {
                    passwordRequirement[3] = true;
                }
            }

            foreach (var notFound in passwordRequirement)
            {
                if (!notFound)
                {
                    required++;
                }
            }

            WriteLine((required > (6 - password.Length)) ? required : (6 - password.Length));
        }

        private static void MarsExploration()
        {
            const string sosMessage = "SOS";
            var receivedMessage = "SOSSOS";
            var iCtr = 0;
            var difference = 0;

            foreach (var character in receivedMessage)
            {
                if (sosMessage[iCtr++] != character)
                {
                    difference++;
                }

                if (iCtr >= 3)
                {
                    iCtr = 0;
                }
            }
            WriteLine($"Difference: {difference}");
        }

        private static void DrawingBook()
        {
            var p = 0;
            var n1 = 0;

            while (true)
            {
                WriteLine("Enter N and P:");
                n1 = int.Parse(ReadLine());
                p = int.Parse(ReadLine());

                if (n1 == -1)
                {
                    break;
                }

                if (n1 % 2 == 0)
                {
                    n1++;
                }

                var fromStart = p / 2;
                var fromEnd = (n1 - p) / 2;

                WriteLine($"{fromStart} :: {fromEnd}");
            }
        }

        private static void AngryProfessor()
        {
            int k = 3;
            int[] a = new int[] { -1, -3, 4, 2 };
            var count = 0;
            foreach (var n in a)
            {
                if (n <= 0)
                {
                    count++;
                }
            }

            if (count < k)
            {
                WriteLine("YES");
            }
            else
            {
                WriteLine("NO");
            }
        }

        private static int UtopianTreeV2(int n)
        {
            var previous = 1;

            for (var iCtr = 1; iCtr <= n; iCtr++)
            {
                if (iCtr % 2 == 1)
                {
                    previous *= 2;
                }
                else
                {
                    previous += 1;
                }
            }

            return previous;
        }

        private static int UtopianTree(int n)
        {
            var current = 1;
            var previous = 1;

            for (var iCtr = 1; iCtr <= n; iCtr++)
            {
                if (iCtr % 2 == 1)
                {
                    current = previous * 2;
                }
                else
                {
                    current = previous + 1;
                }
                previous = current;
            }

            return current;
        }

        private static void PDFViewer()
        {
            var alphabets = "abcdefghijklmnopqrstuvwxyz";
            var word = "abc";
            // var data = "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7";
            var data = "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5";
            var arr1 = Array.ConvertAll(data.Split(), int.Parse);
            var maximum = arr1[0];

            foreach (var character in word)
            {
                var current = arr1[alphabets.IndexOf(character)];
                if (current > maximum)
                {
                    maximum = current;
                }
            }

            var length = maximum * word.Length;
            WriteLine(length);
        }

        private static void TheHurdleRace()
        {
            var nk = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            int n = nk[0];
            int k = nk[1];

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var heighestJump = height[0];
            var numberOfDrink = 0;

            // Need to write Generic Logic to find the Max and Min in Array
            for (var iCtr = 1; iCtr < height.Length; iCtr++)
            {
                if (height[iCtr] > heighestJump)
                {
                    heighestJump = height[iCtr];
                }
            }

            if (heighestJump > k)
            {
                numberOfDrink = heighestJump - k;
            }
            WriteLine($"{numberOfDrink}");
        }

        private static void CatsAndMouse()
        {
            int q = Convert.ToInt32(ReadLine());
            var xyz = Array.ConvertAll(ReadLine().Split(' '), int.Parse);

            int x = xyz[0];
            int y = xyz[1];
            int z = xyz[2];

            var distanceOfX = System.Math.Abs(z - x);
            var distanceOfY = System.Math.Abs(z - y);

            if (distanceOfX == distanceOfY)
            {
                WriteLine("Mouse C");
            }
            else if (distanceOfX < distanceOfY)
            {
                WriteLine("Cat A");
            }
            else
            {
                WriteLine("Cat B");
            }
        }

        private static void ElectronicsShop()
        {
            var bnm = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            int b = bnm[0];
            int n = bnm[1];
            int m = bnm[2];
            var amountToBeSpent = -1;

            int[] keyboards = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            int[] drives = Array.ConvertAll(ReadLine().Split(' '), int.Parse);

            for (var iCtr = 0; iCtr < keyboards.Length; iCtr++)
            {
                for (var jCtr = 0; jCtr < drives.Length; jCtr++)
                {
                    var amount = keyboards[iCtr] + drives[jCtr];
                    if (amount <= b && amount > amountToBeSpent)
                    {
                        amountToBeSpent = amount;
                    }
                }
            }
            WriteLine(amountToBeSpent);
        }

        private static void DayOfProgrammerV2()
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());
            var theDay = 256;
            var febDays = new int[] { 28, 29, 15, 16 };
            var totalDays = 215;
            var date = string.Empty;

            if ((year >= 1700) && (year <= 1917))
            {
                totalDays += (year % 4 == 0) ? febDays[1] : febDays[0];
            }
            else if (year == 1918)
            {
                totalDays += ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))) ? febDays[3] : febDays[2];
            }
            else
            {
                totalDays += ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))) ? febDays[1] : febDays[0];
            }
            date = $"{theDay - totalDays}.09.{year}";
            WriteLine(date);
        }

        private static void DayOfProgrammerV1()
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());
            var date = string.Empty;

            if ((year >= 1700) && (year <= 1917))
            {
                date = (year % 4 == 0) ? $"12.09.{year}" : $"13.09.{year}";
            }
            else if (year == 1918)
            {
                date = ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))) ? $"25.09.{year}" : $"26.09.{year}";
            }
            else
            {
                date = ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))) ? $"12.09.{year}" : $"13.09.{year}";
            }
            WriteLine($"{date}");
        }

        private static void BonAppetit()
        {
            var nk = Array.ConvertAll(ReadLine().TrimEnd().Split(' '), int.Parse);
            int n = nk[0];
            int k = nk[1];
            List<int> bill = ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();
            int b = Convert.ToInt32(ReadLine().Trim());

            var amount = 0;
            for (var iCtr = 0; iCtr < bill.Count; iCtr++)
            {
                if (iCtr == k)
                {
                    continue;
                }
                amount += bill[iCtr];
            }

            if ((amount / 2) == b)
            {
                WriteLine("Bon Appetit");
            }
            else if (b > ((amount / 2)))
            {
                WriteLine($"{bill[k] / 2}");
            }
        }

        private static void MigratoryBirds()
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            var arrayRank = new int[5];
            var max = 0;

            for (var iCtr = 0; iCtr < arrCount; iCtr++)
            {
                var index = arr[iCtr] - 1;
                arrayRank[index] += 1;

                if (arrayRank[index] > max)
                {
                    max = arrayRank[index];
                }
            }

            for (var iCtr = 0; iCtr < 5; iCtr++)
            {
                if (arrayRank[iCtr] == max)
                {
                    WriteLine($"{iCtr + 1}");
                    break;
                }
            }
        }

        private static void BirthdayChocolate()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            var dm = Array.ConvertAll(Console.ReadLine().TrimEnd().Split(' '), int.Parse);
            int d = dm[0];  // Sum
            int m = dm[1];  // Length
            var count = 0;

            for (var iCtr = 0; iCtr < n; iCtr++)
            {
                var sum = 0;
                for (var jCtr = iCtr; jCtr < (iCtr + m); jCtr++)
                {
                    if (jCtr >= n)
                    {
                        continue;
                    }
                    sum += s[jCtr];
                }

                if (sum == d)
                {
                    count++;
                }
            }
            WriteLine($"{count}");
        }

        private static void DivisibleSumPairs()
        {
            var nk = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            int n = nk[0];
            int k = nk[1];
            int[] ar = Array.ConvertAll(ReadLine().Split(' '), int.Parse);

            var count = 0;
            for (var iCtr = 0; iCtr < ar.Length - 1; iCtr++)
            {
                for (var jCtr = iCtr + 1; jCtr < ar.Length; jCtr++)
                {
                    if (((ar[iCtr] + ar[jCtr]) % k) == 0)
                    {
                        count++;
                    }
                }
            }
            WriteLine(count);
        }

        private static void BreakingTheRecords()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] scores = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            var lowest = scores[0];
            var highest = scores[0];
            var lowestCount = 0;
            var highestCount = 0;

            for (var iCtr = 1; iCtr < scores.Length; iCtr++)
            {
                if (scores[iCtr] > highest)
                {
                    highest = scores[iCtr];
                    highestCount++;
                }
                else if (scores[iCtr] < lowest)
                {
                    lowest = scores[iCtr];
                    lowestCount++;
                }
            }
            WriteLine($"{highestCount} {lowestCount}");
            var results = new int[] { highestCount, lowestCount };
        }

        private static void KangarooJumps()
        {
            var x1V1X2V2 = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            var message = "NO";

            int x1 = x1V1X2V2[0];
            int v1 = x1V1X2V2[1];
            int x2 = x1V1X2V2[2];
            int v2 = x1V1X2V2[3];

            if ((x2 > x1) && (v2 > v1))
            {
                message = "NO";
            }
            else
            {
                var d1 = x1 + v1;
                var d2 = x2 + v2;
                while (true)
                {
                    if (d1 == d2)
                    {
                        message = "YES";
                        break;
                    }

                    d1 += v1;
                    d2 += v2;
                }
            }
            WriteLine(message);
        }

        private static void AppleAndOrangesCount()
        {
            string[] st = ReadLine().Split(' ');
            int s = Convert.ToInt32(st[0]);
            int t = Convert.ToInt32(st[1]);

            string[] ab = ReadLine().Split(' ');
            int a = Convert.ToInt32(ab[0]);
            int b = Convert.ToInt32(ab[1]);

            string[] mn = ReadLine().Split(' ');
            int m = Convert.ToInt32(mn[0]);
            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));
            int[] oranges = Array.ConvertAll(ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));

            var count = 0;
            foreach (var apple in apples)
            {
                var distance = a + apple;
                if (distance >= s && distance <= t)
                {
                    count++;
                }
            }
            WriteLine($"{count}");

            count = 0;
            foreach (var orange in oranges)
            {
                var distance = b + orange;
                if (distance >= s && distance <= t)
                {
                    count++;
                }
            }
            WriteLine($"{count}");
        }

        private static void LibraryFines()
        {
            var actual = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            var expected = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            var fine = 0;

            if (actual[2] > expected[2])
            {
                fine = 10000;
            }
            else if (actual[2] == expected[2])
            {
                if (actual[1] > expected[1])
                {
                    fine = 500 * (actual[1] - expected[1]);
                }
                else if (actual[1] == expected[1])
                {
                    if (actual[0] > expected[0])
                    {
                        fine = 15 * (actual[0] - expected[0]);
                    }
                }
            }

            WriteLine($"{fine}");
        }

        private static void GradingStudentsV1()
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = GradingResult.GradingStudents(grades);
        }

        private static void ArrayLeftRotation()
        {
            var arrayData = new int[] { 1, 2, 3, 4, 5 };
            var d = 4;
            var tempArray = new int[arrayData.Length];
            var start = 0;
            for (var iCtr = (d); iCtr < arrayData.Length; iCtr++)
            {
                tempArray[start++] = arrayData[iCtr];
            }

            for (var iCtr = 0; iCtr < d; iCtr++)
            {
                tempArray[start++] = arrayData[iCtr];
            }
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

            for (var index = 0; index < array.Length; index++)
            {
                if (maxNumber < array[index])
                {
                    maxNumber = array[index];
                    maxNumberCount = 1;
                }
                else if (maxNumber == array[index])
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

        private static void AppleAndOrangesCountV2()
        {
            var st = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            int s = st[0];
            int t = st[1];

            var ab = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            int a = ab[0];
            int b = ab[1];

            var mn = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            int m = mn[0];
            int n = mn[1];

            int[] apples = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            int[] oranges = Array.ConvertAll(ReadLine().Split(' '), int.Parse);

            CountFruits(s, t, a, apples);

            CountFruits(s, t, b, oranges);
        }

        private static void AppleAndOrangesCountV3()
        {
            var st = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            var ab = Array.ConvertAll(ReadLine().Split(' '), int.Parse);

            var mn = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            int m = mn[0];
            int n = mn[1];

            int[] apples = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            int[] oranges = Array.ConvertAll(ReadLine().Split(' '), int.Parse);

            CountFruits(st[0], st[1], ab[0], apples);

            CountFruits(st[0], st[1], ab[1], oranges);
        }

        private static void CountFruits(int start, int end, int currentLocation, int[] fruits)
        {
            var count = 0;
            foreach (var fruit in fruits)
            {
                var distance = currentLocation + fruit;
                if (distance >= start && distance <= end)
                {
                    count++;
                }
            }
            WriteLine($"{count}");
        }

        private static int FindMaximumOfArray(int[] arrayItems)
        {
            var maximum = arrayItems[0];

            for (var iCtr = 1; iCtr < arrayItems.Length; iCtr++)
            {
                if (arrayItems[iCtr] > maximum)
                {
                    maximum = arrayItems[iCtr];
                }
            }

            return maximum;
        }

        private static int[] FindMaximumOfArrayWithItsIndex(int[] arrayItems)
        {
            var maximum = arrayItems[0] - 1;
            var index = -1;

            // Need to write Generic Logic to find the Max and Min in Array
            for (var iCtr = 0; iCtr < arrayItems.Length; iCtr++)
            {
                if (arrayItems[iCtr] > maximum)
                {
                    maximum = arrayItems[iCtr];
                    index = iCtr;
                }
            }

            return new int[] { index, maximum };
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