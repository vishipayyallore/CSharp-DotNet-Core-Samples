using static System.Console;

namespace CSharp7.Logic.Programs
{
    public class JumpingOnTheClouds
    {

        public void Execute(int[] arrayValues)
        {
            var jumps = 0;
            for (int iCtr = 0; iCtr < arrayValues.Length - 1; iCtr++)
            {
                if ((iCtr + 2 < arrayValues.Length) && arrayValues[iCtr + 2] == 0)
                {
                    iCtr += 1;
                    jumps++;
                }
                else if (arrayValues[iCtr + 1] != 1 || arrayValues[iCtr + 2] != 1)
                {
                    jumps++;
                }
            }

            WriteLine($"Number Of Jumps: {jumps}");
        }

    }

}
