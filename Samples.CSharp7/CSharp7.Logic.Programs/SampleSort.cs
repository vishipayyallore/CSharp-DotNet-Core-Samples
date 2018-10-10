﻿using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace CSharp7.Logic.Programs
{
    public class SampleSort
    {

        public void Execute(int[] arrayValues)
        {
            var numbersAndCount = new Dictionary<int, int>();

            arrayValues.ToList().ForEach( number =>
            { 
                if(numbersAndCount.ContainsKey(number))
                {
                    numbersAndCount[number] += 1;
                }
                else
                {
                    numbersAndCount.Add(number, 1);
                }
            });

            foreach(var number in numbersAndCount.Keys.OrderBy(x => x))
            {
                for(int iCtr=1; iCtr <=numbersAndCount[number]; iCtr++)
                {
                    Write($"{number} ");
                }
            }
        }

    }

}
