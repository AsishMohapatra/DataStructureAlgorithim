using System;

namespace LinkedListPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var head = InitialiseNodesInALinkedList();
            //head = DeleteHead(head);
            head = InsertAtBeginning(head, 40);
            head = InsertAtBeginning(head, 30);
            head = InsertAtEnd(head, 95);
            head = InsertAtBeginning(head, 10);
            head = InsertAtEnd(head, 100);
            PrintLinkedListUsingrecursion(head);
            head = DeleteHead(head);
            PrintLinkedListUsingrecursion(head);
            head = DeleteTail(head);

            //PrintLinkedList(head);
            PrintLinkedListUsingrecursion(head);

            head = InsertDataAtIndex(head, 1, 10);
            PrintLinkedListUsingrecursion(head);

            head = InsertDataAtIndex(head, 8, 100);
            PrintLinkedListUsingrecursion(head);

            head = InsertDataAtIndex(head, 5, 75);
            PrintLinkedListUsingrecursion(head);

            head = InsertDataAtIndex(head, 15, 1000);
            PrintLinkedListUsingrecursion(head);

            var containsData = Contains(head, 10);
            containsData = Contains(head, 105);
            containsData = Contains(head, 30);
            containsData = Contains(head, 100);
            containsData = Contains(head, 75);

            var containsDataUsingIteration = ContainsIterative(head, 10);
            containsDataUsingIteration = ContainsIterative(head, 105);
            containsDataUsingIteration = ContainsIterative(head, 30);
            containsDataUsingIteration = ContainsIterative(head, 40);
            containsDataUsingIteration = ContainsIterative(head, 100);
            containsDataUsingIteration = ContainsIterative(head, 75);

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
            {
                Console.WriteLine();
                return;
            }
            Console.Write($"{headNode.Data} ");
            PrintLinkedListUsingrecursion(headNode.NextNode);

        }

        public static Node<int> InsertAtBeginning(Node<int> headNode, int x)
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
            if (headNode == null || headNode.NextNode == null) return null;
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

        public static Node<int> InsertDataAtIndex(Node<int> head, int index, int data)
        {
            Console.WriteLine($"Inserting {data} at index {index}");
            var dataNode = new Node<int>(data);
            if (index == 1)
            {
                dataNode.NextNode = head;
                return dataNode;
            }

            var currentNode = head;
            int currentPosition = 1;
            while (currentNode.NextNode != null && currentPosition < index)
            {
                currentNode = currentNode.NextNode;
                currentPosition += 1;
            }

            if (currentPosition == index)
            {
                dataNode.NextNode = currentNode.NextNode;
                currentNode.NextNode = dataNode;
            }
            return head;
        }

        public static int Contains(Node<int> head, int data)
        {
            var currentNode = head;
            int indexOfData = 1;
            while (currentNode != null && currentNode.Data != data)
            {
                indexOfData += 1;
                currentNode = currentNode.NextNode;
                if (currentNode == null)
                {
                    indexOfData = -1;
                }
            }
            Console.WriteLine($"Index of {data} is {indexOfData}");
            return indexOfData;


        }

        public static int ContainsIterative(Node<int> head, int data)
        {
            
            int indexOfData = 1;
            if (head == null) return -1;
            //if (head != null && head.Data != data)
            //{
            //    indexOfData += ContainsIterative(head.NextNode, data);
            //}
            //if (head != null && head.Data == data)
            //{
            //    return indexOfData;
            //}

            return indexOfData;
        }
    }
}
