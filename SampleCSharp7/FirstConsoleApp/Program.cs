using System;
using System.Collections.Generic;
using System.Data;
using AbstractDemo.Lib;
using Chapter1.Lib;
using ClassesAndGenerics;
using static System.Console;
using static System.Math;
using Common.Enums;

namespace FirstConsoleApp
{
    internal static class Program
    {

        private static void Main()
        {
            ForegroundColor = ConsoleColor.Yellow;
            var personHelper = new PersonHelper();
            var scores = new[] { 17, 46, 39, 62, 81, 79, 52, 24, 49 };
            const int threshold = 40;

            var (average, studentCount, _) = personHelper.GetAverageAndCount(scores, threshold);
            WriteLine($"Average was {Round(average,2)} across {studentCount} students. Below Average: {(average < threshold ? " Class score below average." : " Class score above average.")}");

            var student = new Student
            {
                Name = "Dirk",
                LastName = "Strauss",
                CourseCodes = new List<int> {203, 202, 101}
            };

            // Using Deconstruct [As Extension Method]
            var (firstName, surname) = student;
            WriteLine($"[Deconstruct -> As Extension Method] The student name is {firstName} {surname}");

            personHelper.PrintData(student);
            personHelper.PrintDataWithIsKeyword(student);
            personHelper.PrintDataWithIsKeyword(null);
            personHelper.PrintDataWithSwitchCase(student);

            var professor = new Professor
            {
                Name = "Reinhardt",
                LastName = "Botha",
                TeachesSubject = new List<string> { "Mobile Development", "Cryptography" }
            };
            personHelper.PrintData(professor);
            personHelper.PrintDataWithIsKeyword(professor);
            personHelper.PrintDataWithIsKeyword(null);
            personHelper.PrintDataWithSwitchCase(professor);

            //Out Variables V1 Demo
            const string value = "500";
            if(int.TryParse(value, out var number))
            {
                WriteLine($"{number} is a valid integer");
            }
            WriteLine($"{number} is a valid integer");

            //Out Variables V2 Demo (Type inference)
            const string value1 = "1500";
            if (int.TryParse(value1, out var number1))
            {
                WriteLine($"{number1} is a valid integer");
            }

            //Extension Method, Tuple, and out variables.
            const string value2 = "500A";
            var (originalValue, number2, isInteger) = value2.ToInt();
            WriteLine(isInteger ? $"{number2} is a valid integer" : $"{originalValue} is NOT a valid integer");

            var studentV2 = new StudentV2("S20323742");
            var (firstNameV2, surName) = studentV2;
            WriteLine($"The student V2 name is {firstNameV2} {surName}");

            var building = new Building(200, 35, 100);
            building.CalculateShopFloorSpace();
            WriteLine($" The total space for shops is {building.TotalShopFloorSpace} square meters");

            const long oldNumber = 342057239127493;
            const long newNumber = 342_057_239_127_493;
            WriteLine($" Old Number = {oldNumber} and New Number = {newNumber}");

            const int binaryaLiteral = 0b1010_1100_0011_0010_0001_0000;
            WriteLine($"Bit Literal = {binaryaLiteral}!");

            var number3 = 10;
            var number4 = 10;
            var output = MathHelper.GetLargest(number3, number4);
            WriteLine($" Output = {output} Number 3 = {number3} Number 4 = {number4} ");
            output += 25;
            WriteLine($" Output = {output} Number 3 = {number3} Number 4 = {number4} ");

            ref var output1 = ref MathHelper.GetLargest(ref number3, ref number4);
            WriteLine($" Output = {output1} Number 3 = {number3} Number 4 = {number4} ");
            output1 += 25;
            WriteLine($" Output = {output1} Number 3 = {number3} Number 4 = {number4} ");

            ForegroundColor = ConsoleColor.Green;
            unsafe
            {
                WriteLine($" The memory address of number4 is {(IntPtr)(&number4)}");
                WriteLine($" The memory address of output is {(IntPtr)(&output)}");
                fixed (int* refValVar = &output1)
                {
                    var output1MemoryAddress = (IntPtr)(refValVar);
                    WriteLine($" The memory address of output1 (Ref) is {output1MemoryAddress}");
                }
            }

            var studentWithoutEb = new StudentWithoutEb(25);
            WriteLine($"Student Expression Body {studentWithoutEb.Age}");
            var studentWithEb = new StudentWithEb(25);
            WriteLine($"Student Expression Body {studentWithEb.Age}");

            var student1 = new Student();
            try
            {
                WriteLine($"Name Length: {student1.GetNameLength()}");
            }
            catch (Exception error)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error: {error.Message}");
            }
            ForegroundColor = ConsoleColor.Green;

            var classesAndGenericsHelper = new ClassesAndGenericsHelper();
            classesAndGenericsHelper.PerformCatLife(classesAndGenericsHelper.CreateCat(CatType.Lion, LionColorSpectrum.White));
            classesAndGenericsHelper.PerformCatLife(classesAndGenericsHelper.CreateCat(CatType.Tiger, TigerColorSpectrum.Blue));
            classesAndGenericsHelper.PerformCatLife(classesAndGenericsHelper.CreateCat(CatType.Unknown, null));

            var cheetah = new Cheetah();
            cheetah
                .Hunt()
                .Eat()
                .Sleep();
            cheetah
                .SoftPurr(40);
            
            var performActionHelper = new PerformActionHelper();
            // Without Generic Method Parameter.
            performActionHelper
                .PerformIntAction(25)
                .PerformDecimalAction(23.45m)
                .PerformStringAction("Shiva Sai");

            using (var dataSet = new DataSet())
            {
                performActionHelper
                    .PerformAction(50)
                    .PerformAction(23.45m)
                    .PerformAction("Sri Vari")
                    .PerformActionV2(dataSet);
                WriteLine($"An example of this type is {performActionHelper.InspectType(dataSet)}");
            }

            WriteLine($"An example of this type is {performActionHelper.InspectType(25)}");
            WriteLine($"An example of this type is {performActionHelper.InspectType(25.55m)}");
            WriteLine($"An example of this type is {performActionHelper.InspectType("Shiva Sai")}");
            WriteLine($"An example of this type is {performActionHelper.InspectType(CatType.Tiger)}");

            var inspectClassHelper = new InspectClassHelper();
            inspectClassHelper
                .DisplayProperties(new Invoice())
                .DisplayProperties(new SalesOrder())
                .DisplayProperties(new CreditNote());

            //Invoking V1 version.
            inspectClassHelper
                .DisplayPropertiesV1(new Invoice())
                .DisplayPropertiesV1(new SalesOrder())
                .DisplayPropertiesV1(new CreditNote());

            var spaceShipHelper = new SpaceShipHelper();
            spaceShipHelper
                .PerformSpaceShipActions()
                .PerformDestroyerActions()
                .PerformAnnihilatorActions();

            var launchSuttleHelper = new LaunchSuttleHelper();
            launchSuttleHelper.PerformLaunchShuttle();

            WriteLine("\n\nPress any key...");
            ReadKey();
        }

        
    }
}

