using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice
{
    public class LinkedListExercises
    {
        public class SinglyLinkedListNode
        {
            public int Data { get; set; }
            public SinglyLinkedListNode Next { get; set; }
        }

        public static void PrintLinkedList(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode current = head;

            while (current != null)
            {
                Console.WriteLine($"Element: {current.Data}");
                current = current.Next;
            }
        }

        public static SinglyLinkedListNode AddToTail(SinglyLinkedListNode head, SinglyLinkedListNode tail)
        {
            SinglyLinkedListNode current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = tail;
            return current;
        }
    }
}
