using static System.Console;

namespace CSharp7.Logic.Programs
{
    public class ValleyCount
    {

        public void Execute(string valleyPath)
        {
            int iCtr = 0;
            int valleyCount = 0;
            bool isClimbing = false;

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
