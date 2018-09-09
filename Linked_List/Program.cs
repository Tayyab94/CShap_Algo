using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");



            //Custome_Built in linked lit

            // singlyLinkedList singlyLinkedList = new singlyLinkedList();

            // singlyLinkedList.InsertFirstNode(12);
            // singlyLinkedList.InsertFirstNode(13);
            // singlyLinkedList.InsertFirstNode(14);
            // singlyLinkedList.InsertFirstNode(15);
            // singlyLinkedList.InsertFirstNode(16);

            // singlyLinkedList.Displaylist();


            // singlyLinkedList.DeleteFirst();


            // singlyLinkedList.Displaylist();
            // Console.ReadKey();



            string[] words = { "The", "Actor", "Jumped", "Over", "the", "Director" };


            LinkedList<string> sentence = new LinkedList<string>(words);

            DisplayFun(sentence, "The Linked List values");


            sentence.AddFirst("Today");
            DisplayFun(sentence,"Today is Added into the list ");


            LinkedListNode<string> mark1 = sentence.First;

            sentence.RemoveFirst();

            sentence.AddLast(mark1);
            DisplayFun(sentence, "Today is now at the last node in the lisked list node");
            Console.ReadKey();

            sentence.RemoveFirst();

            LinkedListNode<string> curret = sentence.FindLast("the");

            IndicateNode(curret, "Indicate last occurance 'The'");



            sentence.AddAfter(curret, "old");

            sentence.AddAfter(curret, "new one");
            IndicateNode(curret, "old is Added");

            curret = sentence.Find("Actor");
            IndicateNode(curret, "Test 7: Indicate the 'actor' node:");


            sentence.AddBefore(curret, "quick");
            sentence.AddBefore(curret, "skinny");
            IndicateNode(curret, "Test 8: Add 'quick' and 'skinny' before 'actor':");


            Console.ReadKey();




        }

        private static void DisplayFun(LinkedList<string> word, string text)
        {

            Console.Write(text);

            Console.WriteLine();
            foreach (string w in word)
            {
                Console.WriteLine(w + " ");
            }

            Console.WriteLine();
        }


        private static void IndicateNode(LinkedListNode<string> node,string text)
        {
            Console.WriteLine(text);

            if(node.List==null)
            {
                Console.WriteLine($"{node.Value} is not present in the list");

                return;
            }

            StringBuilder result = new StringBuilder("(" + node.Value + ")");


            LinkedListNode<string> nodep = node.Previous;


            while(nodep!=null)
            {
                result.Insert(0, node.Value + " ");
                nodep = nodep.Previous;
            }

            node = node.Next;



            while(node!=null)
            {
                result.Append(" " + node.Value);
                node = node.Next;
            }

            Console.WriteLine(result);

            Console.WriteLine();


        }


    }

    

    public class singlyLinkedList
    {
        private Node first;

        public bool isNullNode()
        {
            return (first == null);
        }


        public void InsertFirstNode(int data)
        {
            Node newNode = new Node();

            newNode.data = data;
            newNode.next = first;
            first =newNode; 
        }


        public Node DeleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }

        public void Displaylist()
        {
            Console.WriteLine("ListNode form the last node to first");

            Node current = first;
            while(current!=null)
            {

                current.displayNode();
                current = current.next;
            }

            Console.WriteLine();
        }



        public void InsertLast(int data)
        {
            Node current = first;

            while(current.next!=null)
            {
                current = current.next;
            }


            Node newNode = new Node();

            newNode.data = data;
            current.next = newNode;
        }

    }

    public class Node
    {
        public int data;
        public Node next;

        public void displayNode()
        {
            Console.WriteLine($"Node Values is =>{data}");
        }
    }
}
