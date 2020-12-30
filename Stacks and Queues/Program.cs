using System;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack NewStack = new Stack();
            Queue NewQueue = new Queue();
            Console.WriteLine("------- STACK -------");
            Console.WriteLine("Stack Push: 1");
            NewStack.Push(1);
            Console.WriteLine("Stack Push: 2");
            NewStack.Push(2);
            Console.WriteLine("Stack Push: 3");
            NewStack.Push(3);
            Console.WriteLine("Stack Push: 4");
            NewStack.Push(4);
            Console.WriteLine("Stack Push: 5");
            NewStack.Push(5);
            Console.Write("Stack Peek: ");
            Console.WriteLine(NewStack.Peek());
            Console.Write("Is Stack Emtpy: ");
            Console.WriteLine(NewStack.IsEmpty());
            Console.Write("Popping: ");
            Console.WriteLine(NewStack.Pop());           
            Console.Write("Popping: ");
            Console.WriteLine(NewStack.Pop());            
            Console.Write("Popping: ");
            Console.WriteLine(NewStack.Pop());            
            Console.Write("Popping: ");
            Console.WriteLine(NewStack.Pop());            
            Console.Write("Popping: ");
            Console.WriteLine(NewStack.Pop());            
            Console.Write("Popping: ");
            Console.WriteLine(NewStack.Pop());
            Console.Write("Is Stack Emtpy: ");
            Console.WriteLine(NewStack.IsEmpty());

            Console.ReadLine();


            Console.WriteLine("------- QUEUE -------");

        }
    }
}
