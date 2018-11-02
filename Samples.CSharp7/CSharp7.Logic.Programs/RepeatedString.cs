using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7.Logic.Programs
{
    public class RepeatedString
    {

        public long Execute(string inputString, long n)
        {
            long count = 0;
            long remaining = 0;

            long toTraverse = (inputString.Length <= n) ? inputString.Length : n;
            for (int iCtr = 0; iCtr < toTraverse; iCtr++)
            {
                if (inputString[iCtr] == 'a')
                {
                    count++;
                }
            }

            if (inputString.Length <= n)
            {
                count = (n / inputString.Length) * count;
                remaining = (n % inputString.Length);

                for (int iCtr = 0; iCtr < remaining; iCtr++)
                {
                    if (inputString[iCtr] == 'a')
                    {
                        count++;
                    }
                }
            }

            return count;
        }

    }

}
