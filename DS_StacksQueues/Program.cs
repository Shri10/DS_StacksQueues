namespace DS_StacksQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures, Demonstration and Implmentation of Stacks and Queues!\n");

            LinkedList<int> stack = new LinkedList<int>();

            Push(stack, 70);
            Push(stack, 30);
            Push(stack, 56);

            Console.WriteLine();
            Display(stack);
            Console.WriteLine();

            while (stack.Count > 0)
            {
                Console.WriteLine($"Top element is {Peek(stack)}");
                Console.WriteLine($"Popped element is {Pop(stack)}");
                Console.WriteLine($"Stack size is {stack.Count}");
                Console.WriteLine();
            }
        }

        static void Push(LinkedList<int> stack, int data)
        {
            stack.AddFirst(data);
        }

        static int Pop(LinkedList<int> stack)
        {
            int poppedValue = stack.First.Value;
            stack.RemoveFirst();
            return poppedValue;
        }

        static int Peek(LinkedList<int> stack)
        {
            return stack.First.Value;
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