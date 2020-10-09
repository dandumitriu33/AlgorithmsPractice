using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsPractice.October2020
{
    public class SupermarketQueue
    {
        /*
         * There is a queue for the self-checkout tills at the supermarket. Your task is write a 
         * function to calculate the total time required for all the customers to check out!
         * input
         * customers: an array of positive integers representing the queue. Each integer represents 
         * a customer, and its value is the amount of time they require to check out.
         * n: a positive integer, the number of checkout tills.
         * output
         * The function should return an integer, the total time required.
         * https://www.codewars.com/kata/57b06f90e298a7b53d000a86/csharp
         */
        public static int CalculateTime(int[] arr, int numberOfQueues)
        {
            int[] queues = new int[numberOfQueues];
            for (int i = 0; i < arr.Length; i++)
            {
                int shortestQueueValue = queues.Min();
                int index = Array.IndexOf(queues, shortestQueueValue);
                queues[index] = shortestQueueValue + arr[i];
            }
            return queues.Max();
        }
    }
}
