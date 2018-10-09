using System.Linq;
using static System.Console;

namespace CSharp7.Logic.Programs
{
    public class ValleyCount
    {

        public void Execute()
        {

            int iCtr = 0;
            int valleyCount = 0;
            bool isClimbing = false;

            WriteLine($"Moutain - Valley Program!");
            Write($"Please Enter Number of Items: ");
            var numberOfItems = int.Parse(ReadLine().Trim());
            Write($"Please Enter Array of Values: ");
            var valleyPath = ReadLine().Trim();

            foreach(var path in valleyPath)
            {
                if(path == 'U')
                {
                    if(iCtr == 0)
                    {
                        isClimbing = true;
                    }
                    iCtr++;
                }
                else if(path == 'D')
                {
                    if (iCtr == 0)
                    {
                        isClimbing = false;
                    }
                    iCtr--;
                }

                if (iCtr == 0 && !isClimbing)
                {
                        valleyCount++;
                }
            }

            Write($"{valleyCount}");
        }

    }

}
