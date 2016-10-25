using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BasicsofImplementation.Lib;
using static System.Console;

namespace BasicsofImplementation.App
{

    class static_out
    {
        public static int r1;
        public static int r2;
        public int add(int x1, int x2)
        {
            r1 = x1 + x2;
            r2 = r1 + x2;
            return 0;
        }
    }

    public class Generic<T>
    {
        public T Field;
    }


    public class MainCls
    {

        class myClass
        {
            public int x1;
            public int x2;
            public myClass(int i, int j)
            {
                x1 = i;
                x2 = j;
            }
            public void meth(myClass o)
            {
                o.x1 *= 2;
                o.x2 /= 2;
            }
        }


        static ulong Sum(ulong value)
        {
            if (value > 0)
            {
                return value + Sum(value - 1);
            }
            else
            {
                return 0;
            }
        }

        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            Generic<int> p1 = new Generic<int>();
            Generic<int> p2 = new Generic<int>();
            p1.Field = 8;
            p2.Field = 4;
            if (p1.Field % p2.Field == 0)
            {
                Console.WriteLine("ABC");
            }
            else
                Console.WriteLine("Prints nothing wrong:");
            Console.ReadLine();

            static_out obj1 = new static_out();
            static_out obj2 = new static_out();
            int x1 = 2;
            obj1.add(x1, x1 + 1);
            obj2.add(5, x1);
            Console.WriteLine(static_out.r1 + " " + static_out.r2);
            Console.ReadLine();

            myClass obj = new myClass(10, 20);
            obj.meth(obj);
            Console.WriteLine(obj.x1 + " " + obj.x2);
            Console.ReadLine();

            ulong sum = 0;
            ulong calculatedSum = 0;
            var numberData = new StringBuilder(1024);
            var numberOfRepeatations = int.Parse(ReadLine().Trim());
            while (numberOfRepeatations-- > 0)
            {
                sum = 0;
                var numberOfRows = int.Parse(ReadLine().Trim());
                numberData = new StringBuilder(1024);
                for ( ; numberOfRows>0; numberOfRows--)
                {
                    //var arrayElements = ReadLine().Trim().Split(' ').Select(ulong.Parse).ToArray();
                    //for ( var iCtr= arrayElements[0]; iCtr>0; iCtr--)
                    //{
                    //    sum += arrayElements[1];
                    //}
                    var arrayElements = ReadLine().Trim().Split(' ');
                    for (var iCtr = long.Parse(arrayElements[0]); iCtr > 0; iCtr--)
                    {
                        numberData.Append(arrayElements[1]);
                    }
                }
                sum = numberData.ToString().Aggregate<char, ulong>(0, (current, number) => current + ulong.Parse(number + string.Empty));

                if (sum < 10)
                {
                    goto Display_Output;
                }

                while (sum > 9)
                {
                    calculatedSum = sum;
                    sum = calculatedSum.ToString().Aggregate<char, ulong>(0, (current, number) => current + ulong.Parse(number + string.Empty));
                    //while (calculatedSum > 0)
                    //{
                    //    sum += calculatedSum % 10;
                    //    calculatedSum /= 10;
                    //}
                }

            Display_Output:
                WriteLine($"{sum}");
            }
            

            Printhackerearth.Run();

            LittleJhoolPsychicPowers.Run();

            TheGreatKian.Run();

            CountDigits.Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
