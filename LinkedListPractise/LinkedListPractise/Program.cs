using System;

namespace LinkedListPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var head=InitialiseNodesInALinkedList();
            //head = DeleteHead(head);
            head=InsertAtBeginning(head, 40);
            head = InsertAtBeginning(head, 30);
            head = InsertAtEnd(head, 95);
            head = InsertAtBeginning(head, 10);
            head = InsertAtEnd(head, 100);
            PrintLinkedListUsingrecursion(head);
            head = DeleteHead(head);
            PrintLinkedListUsingrecursion(head);
            head = DeleteTail(head);
            head = DeleteTail(head);
            head = DeleteTail(head);
            head = DeleteTail(head);
            head = DeleteTail(head);
            head = DeleteTail(head);
            head = DeleteTail(head);
            head = DeleteTail(head);
            head = DeleteTail(head);
            head = DeleteTail(head);

            //PrintLinkedList(head);
            PrintLinkedListUsingrecursion(head);

        }

        /// <summary>
        /// Initialise elements of a Linked list
        /// </summary>
        /// <returns></returns>
        public static Node<int> InitialiseNodesInALinkedList()
        {
            Node<int> head = new Node<int>(50);
            head.NextNode = new Node<int>(70);
            head.NextNode.NextNode = new Node<int>(80);
            head.NextNode.NextNode.NextNode = new Node<int>(90);
            return head;
        }

        /// <summary>
        /// Print the elements of a linked list if Head is given
        /// </summary>
        /// <param name="headNode"></param>
        public static void PrintLinkedList(Node<int> headNode)
        {
            var currentNode = headNode;
            while (currentNode != null)
            {
                Console.WriteLine($"Node data ::  {currentNode.Data}");
                currentNode = currentNode.NextNode;
            }
        }

        /// <summary>
        /// Print the items of linked list using iteration
        /// </summary>
        /// <param name="headNode"></param>
        public static void PrintLinkedListUsingrecursion(Node<int> headNode)
        {
            if (headNode == null)
                return;
            Console.Write($"{headNode.Data} ");
            PrintLinkedListUsingrecursion(headNode.NextNode);
            Console.WriteLine();
        }

        public static Node<int> InsertAtBeginning(Node<int> headNode,int x)
        {
            Node<int> newHead = new Node<int>(x);
            newHead.NextNode = headNode;
            return newHead;
        }

        public static Node<int> InsertAtEnd(Node<int> headNode, int x)
        {
            Node<int> endNode = new Node<int>(x);
            if (headNode == null)
                return endNode;
            var currentNode = headNode;
            while (currentNode.NextNode != null)
            {
                currentNode = currentNode.NextNode;
            }

            currentNode.NextNode = endNode;
            return headNode;
        }

        public static Node<int> DeleteHead(Node<int> headNode)
        {
            Console.WriteLine("Deleting Head item");
            if (headNode == null) return null;
            var oldHead = headNode;
            headNode = headNode.NextNode;
            oldHead = null;
            return headNode;
        }

        public static Node<int> DeleteTail(Node<int> headNode)
        {
            Console.WriteLine("Deleting tail item");
            if (headNode == null || headNode.NextNode==null) return null;
            var currentNode = headNode;
            Node<int> previousNode = null;
            while (currentNode.NextNode != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.NextNode;
            }
            previousNode.NextNode = null;
            return headNode;
        }

    }
}
