using System;

namespace Stacks_and_Queues
{
    public class Queue
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public void Enqueue(int data)
        {
            Node TempNode = new Node(data);
            if (Tail != null)
            {
                Tail.Next = TempNode;
            }

            else { Tail = TempNode; }

            if(Head == null)
            {
                Head = TempNode;
            }
        }
        public int Dequeue()
        {
            int data = Head.Data;
            Head = Head.Next;
            if (Head == null)
            {
                Tail = null;
            }
            return data;
        }
        public int Peek()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("The Queue is empty");
                return 0;
            }
            else { return Head.Data; }
        }
        public bool IsEmpty()
        {
            return Head == null;
        }


    }
}
