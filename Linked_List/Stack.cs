using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{


   public class Stack
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack(3);
            //stack.push("Ali");
            //stack.push("Ali 2");
            //stack.push("Ali 1");
            //stack.push("Ali 5");

            //stack.push("Hamce");
            //stack.push("Usman");

            //Console.WriteLine("The Stack Contain the Following.");

            //while(!stack.isEmpty())
            //{
            //    string mo = stack.Pop();
            //    Console.WriteLine(mo); 
            //}


            //Console.ReadKey();




            //Built in Stack 

            DemoStack();

        }


        private int size;

        private string[] stackArray;

        private int top;

        public Stack(int s)
        {

            this.size = s;

            this.stackArray = new string[size];

            top = -1;
        }


        public void push(string m)
        {
            if(isFull())
            {
                Console.WriteLine($"{m} is not Added into the Stack, Because it's Full Now");
            }
            else
            {
                top++;
                stackArray[top] = m;
            }
        }

        private bool isFull()
        {
            return (size - 1 == top);
        }



        public string Pop()
        {
            if(isEmpty())
            {
                Console.WriteLine("Stack is emplty");
                return " ";
            } 
            else
            {
                int topPop = top;
                top--;
                return stackArray[topPop];
            }
        }

        private bool isEmpty()
        {
            return (top == -1);
        }

        public string Peak()
        {
            return stackArray[top];
        }


        private static void DemoStack()
        {
            Stack<string> name = new Stack<string>();

            name.Push("Tayyab");
            name.Push("bhatti"); name.Push("BSit");
            name.Push("Awesome");


            Console.WriteLine("Now the Demo Stack Contain the Following elements");

            foreach (object item in name)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Popping Up the Stack {name.Pop()}");

            Console.WriteLine($"Peak at next item to displayed what will be destcked {name.Pop()}");

            foreach (object item in name)
            {
                Console.WriteLine(item);
            }


            Stack<string> stack2 = new Stack<string>(name.ToArray());

            Console.WriteLine("content of the first Copy");

            foreach (string name1 in stack2)
            {
                Console.WriteLine(name1);
            }
            Console.WriteLine();


            string[] array2 = new string[name.Count * 2];

            name.CopyTo(array2, name.Count);


            Stack<string> stack3 = new Stack<string>(array2);

            Console.WriteLine("content of the Arry Copy with Null");

            foreach (string name1 in stack3)
            {
                Console.WriteLine(name1);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
