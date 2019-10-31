using LogicPrograms.Interfaces;
using static System.Console;

namespace LogicPrograms.Logics
{

    public class SortBinaryArray : ISortBinaryArray
    {

        public void SortArray(int[] arrayItems)
        {
            var oneCount = 0;

            foreach (var item in arrayItems)
            {
                if (item == 1)
                {
                    oneCount++;
                    continue;
                }
                Write($"{item} ");
            }

            for (var counter = 0; counter < oneCount; counter++)
            {
                Write($"1 ");
            }
        }

    }

}
