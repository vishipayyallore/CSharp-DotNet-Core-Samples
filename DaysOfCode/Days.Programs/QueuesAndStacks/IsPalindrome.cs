using Days.CoreLibrary;
using System;

namespace Days.Programs.QueuesAndStacks
{
    public class IsPalindrome : IProgram
    {
        public void Run()
        {
            var stackNQueue = new StackNQueue();
            bool isPalindrome = true;

            foreach (char c in Console.ReadLine().Trim())
            {
                stackNQueue.pushCharacter(c);
                stackNQueue.enqueueCharacter(c);
            }


            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
