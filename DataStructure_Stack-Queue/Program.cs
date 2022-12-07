namespace DataStructure_Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Stacks and Queues");
            LinkedList queue = new LinkedList();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("\n~~~~~~~~~Queue elements~~~~~~~~~");
            queue.Display();

            queue.Dequeue();
            Console.WriteLine("\n~~~~~~~~~Queue elements~~~~~~~~~");
            queue.Display();

            queue.Dequeue();
            Console.WriteLine("\n~~~~~~~~~Queue elements~~~~~~~~~");
            queue.Display();

            queue.Dequeue();
            Console.WriteLine("\n~~~~~~~~~Queue elements~~~~~~~~~");
            queue.Display();
        }
    }
}