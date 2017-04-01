using Days.CoreLibrary;
using System;
using static System.Console;

namespace Days.Programs.QueuesAndStacks
{
    public class IsPalindrome : IProgram
    {
        public void Run()
        {
            var stackNQueue = new StackNQueue();
            bool isPalindrome = true;

            var inputString = ReadLine().Trim();
            foreach (char c in inputString)
            {
                stackNQueue.PushCharacter(c);
                stackNQueue.EnqueueCharacter(c);
            }

            for (var iCtr = 0; iCtr < inputString.Length / 2; iCtr++)
            {
                if (stackNQueue.PopCharacter() != stackNQueue.DequeueCharacter())
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Write($"The word, {inputString}, is a palindrome.");
            }
            else
            {
                Write($"The word, {inputString}, is not a palindrome.");
            }
        }
    }
}
