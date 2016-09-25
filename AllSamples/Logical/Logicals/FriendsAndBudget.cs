using CoreResuables;
using static System.Console;

namespace Logicals
{
    public class FriendsAndBudget : IProgram
    {
        #region Methods
        public void Run()
        {
            var rows = int.Parse(ReadLine().Trim());
            if ((rows < 1) || (rows > 10))
            {
                return;
            }

            for (; rows > 0; rows--)
            {
                var arrayValues = ReadLine().Trim().Split(' ');
                var friendsCount = int.Parse(arrayValues[0]);
                var amountInHand = long.Parse(arrayValues[1]);
                var friends = new int[friendsCount];

                if ((amountInHand < 1) || (amountInHand > 1000000000000))
                {
                    return;
                }
                for (var iCtr = 0; iCtr < friendsCount; iCtr++)
                {
                    var outputValue = int.Parse(ReadLine().Trim());
                    friends[iCtr] = outputValue > 1000000 ? 0 : outputValue;
                }

                var found = false;
                for (var iCtr = 0; iCtr < friendsCount; iCtr++)
                {
                    if (found) break;
                    long sum = 0;
                    for (var jCtr = iCtr; jCtr >= 0; jCtr--)
                    {
                        sum += friends[jCtr];
                        if (sum != amountInHand) continue;
                        found = true;
                        break;
                    }
                }
                WriteLine(found ? "Yes" : "No");
            }
        }
        #endregion
    }
}
