using System;

namespace Stacks_and_Queues
{
    public class Stack
    {
        public Node Top { get; set; }
        public Node Bottom { get; set; }

        public void Push(int data)
        {
            Node TempNode = new Node(data);
            TempNode.Next = Top;
            Top = TempNode;
        }

        public int Pop()
        {
            if (Top == null)
            {
                Console.WriteLine("The Stack is empty, there is nothing to Pop.");
                return 0;
            }

            else
            {
                int Data = Top.Data;
                Top = Top.Next;
                return Data;
            }            
        }

        public bool IsEmpty()
        {
            return Top == null;
        }

        public int Peek()
        {
            if (Top == null)
            {
                Console.WriteLine("The Stack is empty");
                return 0;
            }
            return Top.Data;
        }
    }
}
