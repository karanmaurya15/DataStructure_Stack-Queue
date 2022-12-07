using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Stack_Queue
{
    internal class LinkedList
    {
        Node front;
        Node rear;
        internal void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine("{0} is inserted into Queue", data);
        }
        internal void Display()
        {
            Node temp = this.front;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "\n");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
