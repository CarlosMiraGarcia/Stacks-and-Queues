namespace Stacks_and_Queues
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; } = null;

        public Node(int data)
        {
            this.Data = data;
        }
    }

}
