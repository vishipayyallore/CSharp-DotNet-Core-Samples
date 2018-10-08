using System.Linq;
using static System.Console;

namespace CSharp7.Logic.Programs
{
    public class SockMerchant
    {

        public void Execute()
        {

            int iCtr = 0;
            int valleyCount = 0;
            WriteLine($"Moutain - Valley Program!");
            Write($"Please Enter Number of Items: ");
            var numberOfItems = int.Parse(ReadLine().Trim());
            Write($"Please Enter Array of Values: ");
            var valleyPath = ReadLine().Trim();

            foreach(var path in valleyPath)
            {
                if(path == 'U')
                {
                    iCtr++;
                }
                else if(path == 'D')
                {
                    iCtr--;
                }

                if(iCtr == 0)
                {
                    valleyCount++;
                }
            }

        }

    }

}
