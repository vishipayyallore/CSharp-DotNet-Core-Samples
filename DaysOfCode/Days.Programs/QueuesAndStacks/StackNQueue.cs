using System.Collections.Generic;

namespace Days.Programs.QueuesAndStacks
{

    public class StackNQueue
    {

        Stack<char> stackData = new Stack<char>();
        Queue<char> queueData = new Queue<char>();

        public void PushCharacter(char ch)
        {
            stackData.Push(ch);
        }

        public void EnqueueCharacter(char ch)
        {
            queueData.Enqueue(ch);
        }

        public char PopCharacter()
        {
            return stackData.Pop();
        }

        public char DequeueCharacter()
        {
            return queueData.Dequeue();
        }

    }

}
