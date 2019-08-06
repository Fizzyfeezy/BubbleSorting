using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UNSORTED ARRAY \n");
            Random generator = new Random();
            int[] unsortedArray = new int[10];
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = generator.Next(-100, 100);
                Console.Write(unsortedArray[i] + ", ");
            }

            Console.WriteLine("\n\n");

            int[] sortedArray = BubbleSort(unsortedArray);
            Console.WriteLine("BUBBLE SORTED ARRAY \n");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + ", ");
            }

            Console.ReadLine();
        }
        private static int[] BubbleSort(int[] unsortedArray)
        {
            Console.WriteLine("ITERATIONS \n");
            int length = unsortedArray.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1 - i; j++)
                {
                    if (unsortedArray[j] > unsortedArray[j + 1])
                    {
                        int num = unsortedArray[j];
                        unsortedArray[j] = unsortedArray[j + 1];
                        unsortedArray[j + 1] = num;
                    }
                }
                foreach (var element in unsortedArray)
                {
                    Console.Write(element + " ");
                }
                Console.Write("\n\n");
            }
            Console.WriteLine("");

            return unsortedArray;
        }
        /*Data Structures are structures programmed to store ordered data, so that various operations can be performed on it easily. Abstract data structure are complex Data Structures, which are used to store large and connected data. e.g Linked List, Tree, Graph, Stack and Queue etc.
        An algorithm is a finite set of instructions or logic, written in order, to accomplish a certain predefined task.A linked list is a linear data structure (like arrays) where each element is a separate object.
        A queue or FIFO (first in, first out) is an abstract data type that serves as a collection of elements, with two principal operations: enqueue, the process of adding an element to the collection.Linear Data Structures: The data structure where data items are organized sequentially or linearly where data elements attached one after another. e.g array, stack, queue link list:tree,graph
        A Stack is a LIFO (Last In First Out) data structure where element that added last will be deleted first. All operations on stack are performed from on end called TOP. A Queue is a FIFO (First In First Out) data structure where element that added first will be deleted first. In queue, insertion is performed from one end called REAR and deletion is performed from another end called FRONT./
        A tree is collection of nodes where these nodes are arranged hierarchically and form a parent child relationships. A Graph is a collection of a finite number of vertices and an edges that connect these vertices. When your ticket is in the waiting list. (Mostly railways and buses), CPU task scheduling, When you call a service centre and told to wait(when all support people are busy), your call enters a queue.
        · Compiler Design,Operating System,Database Management System,Statistical analysis package,Numerical Analysis,Graphics, Artificial Intelligence,Simulation...
        Mathematica supports procedural, recursive, rule-based, functional, and even object-oriented styles (to some degree), I believe it is the functional and rule-based styles that are most important to master.
        A delegate is a type that hold method reference in an object*/
    }
}
