namespace DS_StacksQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures, Demonstration and Implmentation of Stacks and Queues!\n");
            
            Console.WriteLine("First the Stack.");

            LinkedList<int> stack = new LinkedList<int>();

            Push(stack, 70);
            Push(stack, 30);
            Push(stack, 56);

            Console.WriteLine();
            DisplayStack(stack);
            Console.WriteLine();

            while (stack.Count > 0)
            {
                Console.WriteLine($"Top element is {Peek(stack)}");
                Console.WriteLine($"Popped element is {Pop(stack)}");
                Console.WriteLine($"Stack size is {stack.Count}");
                Console.WriteLine();
            }

            Console.WriteLine();
            
            Console.WriteLine("Now the Queue.");

            LinkedList<int> queue = new LinkedList<int>();

            Enqueue(queue, 56);
            Enqueue(queue, 30);
            Enqueue(queue, 70);

            Console.WriteLine();
            DisplayQueue(queue);
            Console.WriteLine();

        }

        ///STACK
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

        static void DisplayStack(LinkedList<int> stack)
        {
            var node = stack.First;

            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
        ///STACK DONE

        ///QUEUE
        static void Enqueue(LinkedList<int> queue, int data)
        {
            queue.AddLast(data);
        }

        static void DisplayQueue(LinkedList<int> queue)
        {
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
        }
        ///QUEUE DONE

    }
}