﻿using System;
using static AlgorithmsPractice.LinkedListExercises;

namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array exercises
            // Reverse an array
            //int[] sourceArray = new int[5] { 9, 8, 7, 6, 5 }; // expected 5, 6, 7, 8, 9
            //ArrayExercises.ReverseArray(sourceArray);

            // Find the 3rd maximum number
            //int[] sourceArray = new int[6] { 1, 2, 3, 4, 5, 6 }; // expected 4
            //ArrayExercises.ThirdMaximumNumber(sourceArray);

            // Max Hourglass sum in matrix (6x6 array) -9 is the lowest number
            //int[,] sourceArray = new int[,]
            //{
            //    { -9, -9, -9, 1, 1, 1 },
            //    { 0, -9, 0, 4, 3, 2},
            //    { -9, -9, -9, 1, 2, 3},
            //    { 0, 0, 8, 6, 6, 0},
            //    { 0, 0, 0, -2, 0, 0},
            //    { 0, 0, 1, 2, 4, 0}
            //};
            //ArrayExercises.MaxHourglass(sourceArray);

            // Sort array by parity - even numbers first, then odd numbers
            //// Time complexity O(N), Space complexity O(N)
            //int[] sourceArray = new[] { 3, 4, 2, 1 }; // expected 4 2 3 1
            //ArrayExercises.SortArrayParityTONSON(sourceArray);
            //// Time complxity O(N), Space complexity O(1)
            //Console.WriteLine();
            //ArrayExercises.SortArrayParityTONSO1(sourceArray);

            // Flip Invert an array of binary values (trick solution with pointers)
            //int[,] sourceArray = new int[,] 
            //{
            //    { 1, 1, 0, 0 },
            //    { 1, 0, 0, 1 },
            //    { 0, 1, 1, 1 },
            //    { 1, 0, 1, 0}
            //};
            //// expected result
            ////{
            ////    { 1, 1, 0, 0},
            ////    { 0, 1, 1, 0},
            ////    { 0, 0, 0, 1},
            ////    { 1, 0, 1, 0}
            ////}
            //ArrayExercises.FlipInvert(sourceArray);

            // Binary search - sorted array
            //int[] sourceArray = new int[] { -1, 0, 3, 5, 9, 12 };
            //int target = 9;
            //ArrayExercises.BinarySearch(sourceArray, target);

            // Shifted Array Search - sorted array
            //int[] sourceArray = new int[] { 9, 12, 17, 2, 4, 5 };
            //int target = 2;
            //Console.WriteLine($"The index for {target} is {ArrayExercises.ShiftedArraySearch(sourceArray, target)}");

            #endregion

            #region Linked Lists exercises
            
            SinglyLinkedListNode head = new SinglyLinkedListNode() { Data = 12, Next = null };

            SinglyLinkedListNode first = new SinglyLinkedListNode() { Data = 24, Next = null };
            head.Next = first;

            SinglyLinkedListNode second = new SinglyLinkedListNode() { Data = 36, Next = null };
            first.Next = second;

            SinglyLinkedListNode third = new SinglyLinkedListNode() { Data = 48, Next = null };
            second.Next = third;

            SinglyLinkedListNode insertTest = new SinglyLinkedListNode() { Data = 16, Next = null };
            insertTest.Next = head.Next;
            head.Next = insertTest;

            // Print the elements of a Linked List w/ insert
            //PrintLinkedList(head);

            // Insert  node at the Tail of the Linked List
            //PrintLinkedList(head);
            SinglyLinkedListNode tailNode = new SinglyLinkedListNode() { Data = 60, Next = null };
            SinglyLinkedListNode tail = AddToTail(head, tailNode);
            //Console.WriteLine("Tail added.");
            //PrintLinkedList(head);

            // Insert node at the Head
            PrintLinkedList(head);
            SinglyLinkedListNode newHead = new SinglyLinkedListNode() { Data = 10, Next = null };
            newHead.Next = head;
            Console.WriteLine("New Head added");
            PrintLinkedList(newHead);


            #endregion



        }
    }
}
