using System;
using static AlgorithmsPractice.LinkedListExercises;

namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array exercises

            // First int duplicate in Array - values only between 1 and array.length; all positive
            // the first occurence of the 2nd number - the number itself not the index
            int[] array1 = new int[6] { 1, 2, 1, 2, 3, 3 }; // 1
            int[] array2 = new int[6] { 2, 1, 3, 5, 3, 2 }; // 3
            int[] array3 = new int[6] { 1, 2, 3, 4, 5, 6 }; // -1
            Console.WriteLine("O(N^2) time complexity");
            Console.WriteLine(ArrayExercises.FirstDuplicateTONSquared(array1)); 
            Console.WriteLine(ArrayExercises.FirstDuplicateTONSquared(array2)); 
            Console.WriteLine(ArrayExercises.FirstDuplicateTONSquared(array3));
            Console.WriteLine("Time Complexity O(N) Space Complexity O(N) via HashSet w/ contains.");
            Console.WriteLine(ArrayExercises.FirstDuplicateHashSet(array1));
            Console.WriteLine(ArrayExercises.FirstDuplicateHashSet(array2));
            Console.WriteLine(ArrayExercises.FirstDuplicateHashSet(array3));
            // between 1 and array.length detail
            // use a trick where we iterate through the array and the number we are looking at abs(it) like an index
            // we check if the number before that index is negative
            // if not we then make the number before it negative
            // if yes - then this is a number we have seen before so return it and end the process
            Console.WriteLine("Time Complexity O(N) Space Complexity not modified");
            Console.WriteLine(ArrayExercises.FirstDuplicateTrick(array1));
            Console.WriteLine(ArrayExercises.FirstDuplicateTrick(array2));
            Console.WriteLine(ArrayExercises.FirstDuplicateTrick(array3));

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

            //SinglyLinkedListNode head = new SinglyLinkedListNode() { Data = 12, Next = null };

            //SinglyLinkedListNode first = new SinglyLinkedListNode() { Data = 24, Next = null };
            //head.Next = first;

            //SinglyLinkedListNode second = new SinglyLinkedListNode() { Data = 36, Next = null };
            //first.Next = second;

            //SinglyLinkedListNode third = new SinglyLinkedListNode() { Data = 48, Next = null };
            //second.Next = third;

            //SinglyLinkedListNode insertTest = new SinglyLinkedListNode() { Data = 16, Next = null };
            //insertTest.Next = head.Next;
            //head.Next = insertTest;

            //// Print the elements of a Linked List w/ insert
            ////PrintLinkedList(head);

            //// Insert  node at the Tail of the Linked List
            ////PrintLinkedList(head);
            //SinglyLinkedListNode tailNode = new SinglyLinkedListNode() { Data = 60, Next = null };
            //SinglyLinkedListNode tail = AddToTail(head, tailNode);
            ////Console.WriteLine("Tail added.");
            ////PrintLinkedList(head);

            //// Insert node at the Head
            ////PrintLinkedList(head);
            //SinglyLinkedListNode newHead = new SinglyLinkedListNode() { Data = 10, Next = null };
            //newHead.Next = head;
            ////Console.WriteLine("New Head added");
            ////PrintLinkedList(newHead);

            //// Insert node at position - 0 starting
            ////PrintLinkedList(newHead);
            //SinglyLinkedListNode nodeToInsert = new SinglyLinkedListNode() { Data = 2222, Next = null };
            //int position = 2;
            //int counter = 1;
            //SinglyLinkedListNode current = newHead;

            //while (counter < position)
            //{
            //    current = current.Next;
            //    counter++;
            //}

            //nodeToInsert.Next = current.Next;
            //current.Next = nodeToInsert;
            ////Console.WriteLine("Node inserted.");
            ////PrintLinkedList(newHead);

            //// Delete node at position - 0 starting
            //PrintLinkedList(newHead);
            //position = 2;
            //counter = 1;
            //current = newHead;

            //while (counter < position)
            //{
            //    current = current.Next;
            //    counter++;
            //}

            //current.Next = current.Next.Next;
            //Console.WriteLine("Node removed from list.");
            //PrintLinkedList(newHead);

            //// Reverse print a linked list
            //ReversePrintRecursive(newHead);
            #endregion

            #region String exercises

            // First non-repeating character in the string - that character is only there once
            //string input1 = "aaabcccdeeef"; // b
            //string input2 = "abcbad"; // c
            //string input3 = "abcabcabc"; // _
            //Console.WriteLine(StringExercises.FirstNonRepeatingTNSquared(input1));
            //Console.WriteLine(StringExercises.FirstNonRepeatingTNSquared(input2));
            //Console.WriteLine(StringExercises.FirstNonRepeatingTNSquared(input3));
            //Console.WriteLine("O 2N w Dictionary");
            //Console.WriteLine(StringExercises.FirstNonRepeatingTN2Dictionary(input1));
            //Console.WriteLine(StringExercises.FirstNonRepeatingTN2Dictionary(input2));
            //Console.WriteLine(StringExercises.FirstNonRepeatingTN2Dictionary(input3));
            //Console.WriteLine("O 2N w Array");
            //Console.WriteLine(StringExercises.FirstNonRepeatingTN2Array(input1));
            //Console.WriteLine(StringExercises.FirstNonRepeatingTN2Array(input2));
            //Console.WriteLine(StringExercises.FirstNonRepeatingTN2Array(input3));
            //Console.WriteLine("IndexOf and LastIndexOf(Char) build in functions equality");
            //Console.WriteLine(StringExercises.FirstNonRepeatingIndexEquality(input1));
            //Console.WriteLine(StringExercises.FirstNonRepeatingIndexEquality(input2));
            //Console.WriteLine(StringExercises.FirstNonRepeatingIndexEquality(input3));

            #endregion

        }
    }
}
