using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace AllChallenges.Lib
{
    public class PhoneBook
    {
        public static void Run()
        {
            var numberOfItems = int.Parse(ReadLine().Trim());
            var phoneBook = new Dictionary<string, string>();
            for (var iCtr = 0; iCtr < numberOfItems; iCtr++)
            {
                var dataEntry = ReadLine().Trim().Split(' ').ToArray();
                if (!phoneBook.ContainsKey(dataEntry[0]))
                {
                    phoneBook.Add(dataEntry[0], dataEntry[1]);
                }
            }
            for (var iCtr = 0; iCtr < numberOfItems; iCtr++)
            {
                var userName = ReadLine().Trim();
                var output = !phoneBook.ContainsKey(userName) ? "Not found" : string.Format("{0}={1}", userName, phoneBook[userName]);
                WriteLine($"{output}");
            }
        }
    }
}
