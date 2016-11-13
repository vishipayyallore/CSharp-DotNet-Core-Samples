﻿using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace ByteCode1._0.Lib
{
    public class FruitsPrice
    {

        public static void Run()
        {
            var fruitsDictionary = new SortedDictionary<int, int>();
            var fruitsPrice = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var fruitsQuantity = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var amountAvailable = int.Parse(ReadLine().Trim());
            var totalFruits = 0;

            for (var iCtr = 0; iCtr < fruitsPrice.Length; iCtr++)
            {
                fruitsDictionary.Add(fruitsPrice[iCtr], fruitsQuantity[iCtr]);
            }

            fruitsDictionary.Keys.CopyTo(fruitsPrice, 0);
            fruitsDictionary.Values.CopyTo(fruitsQuantity, 0);

        ProcessPurchase:
            for (var iCtr = 0; iCtr < fruitsPrice.Length; iCtr++)
            {
                if ((amountAvailable < fruitsPrice[iCtr]) || (fruitsQuantity[iCtr] <= 0)) continue;
                totalFruits++;
                fruitsQuantity[iCtr]--;
                amountAvailable -= fruitsPrice[iCtr];
            }

            if (amountAvailable >= fruitsPrice[0] && fruitsQuantity[0] > 0)
            {
                goto ProcessPurchase;
            }
            WriteLine($"{totalFruits}");
        }
    }
}
