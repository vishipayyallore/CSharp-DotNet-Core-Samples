﻿using BasicProgramming.CoreLibrary;
using static System.Console;

namespace Programs.Library
{
    class PalindromicString : IProgram
    {

        #region Methods
        public void Run()
        {
            var jCtr = 0;
            var output = "YES";
            var data = ReadLine().Trim();

            for (var iCtr = data.Length - 1; iCtr >= 0; iCtr--, jCtr++)
            {
                if (data[iCtr].Equals(data[jCtr])) continue;
                output = "NO";
                break;
            }
            WriteLine(output);
        }
        #endregion

    }
}
