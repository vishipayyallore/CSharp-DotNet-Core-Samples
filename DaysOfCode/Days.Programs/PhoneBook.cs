using Days.CoreLibrary;
using System.Collections.Generic;
using static System.Console;

namespace Days.Programs
{

    public class PhoneBook : IProgram
    {
        public void Run()
        {
            var phoneBook = new Dictionary<string, string>();
            var iterations = int.Parse(ReadLine().Trim());
            for (var iCtr = 0; iCtr < iterations; iCtr++)
            {
                var dataEntry = ReadLine().Trim().Split(' ');
                if (!phoneBook.ContainsKey(dataEntry[0]))
                {
                    phoneBook.Add(dataEntry[0], dataEntry[1]);
                }
            }

            while (iterations-- > 0)
            {
                var userName = ReadLine().Trim();
                var output = !phoneBook.ContainsKey(userName) ? "Not found" : string.Format("{0}={1}", userName, phoneBook[userName]);
                WriteLine($"{output}");
            }
        }
    }

}
