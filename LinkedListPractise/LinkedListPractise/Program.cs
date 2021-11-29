using System;

namespace LinkedListPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var head=InitialiseNodesInALinkedList();
            PrintLinkedList(head);
        }

        public static Node<int> InitialiseNodesInALinkedList()
        {
            Node<int> head = new Node<int>(5);
            head.NextNode = new Node<int>(8);
            head.NextNode.NextNode = new Node<int>(15);
            head.NextNode.NextNode.NextNode = new Node<int>(29);
            return head;
        }

        public static void PrintLinkedList(Node<int> headNode)
        {
            var currentNode = headNode;
            while (currentNode != null)
            {
                Console.WriteLine($"Node data ::  {currentNode.Data}");
                currentNode = currentNode.NextNode;
            }
        }
    }
}
