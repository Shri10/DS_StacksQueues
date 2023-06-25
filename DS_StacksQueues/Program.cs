namespace DS_StacksQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures, Demonstration and Implmentation of Stacks and Queues!");

            LinkedList<int> stack = new LinkedList<int>();

            Push(stack, 70);
            Push(stack, 30);
            Push(stack, 56);

            Display(stack);

        }

        static void Push(LinkedList<int> stack, int data)
        {
            stack.AddFirst(data);
        }

        static void Display(LinkedList<int> stack)
        {
            var node = stack.First;

            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

    }
}