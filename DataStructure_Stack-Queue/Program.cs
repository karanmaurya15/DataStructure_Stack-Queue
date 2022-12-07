namespace DataStructure_Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Stacks and Queues");
            LinkedList stack = new LinkedList();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("\n--------stack elements--------");
            stack.Display();
        }
    }
}