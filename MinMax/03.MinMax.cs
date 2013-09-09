/* Task 3
 * Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.*/

using System;
using System.Linq;

class MinMax
{

    static void Main()
    {
        Console.Write("Enter the numbers count: ");
        int numbers = int.Parse(Console.ReadLine());
        int[] numberArray = new int[numbers];

        for (int i = 0; i < numbers; i++)
        {
            numberArray[i] = int.Parse(Console.ReadLine());
        }

        int minimum = numberArray[0];
        int maximum = numberArray[0];
        for (int i = 0; i < numberArray.Length; i++)
        {
            if (maximum < numberArray[i])
            {
                maximum = numberArray[i];
            }
            if (minimum > numberArray[i])
            {
                minimum = numberArray[i];
            }
        }
        Console.WriteLine("Minimum is {0}", minimum);
        Console.WriteLine("Maximum is {0}", maximum);                     
    }
}