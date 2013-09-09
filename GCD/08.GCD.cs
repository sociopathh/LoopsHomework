/* Task 8 
 * Write a program that calculates the greatest common divisor 
 * (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).*/

using System;

class GCD
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());

        if (a < b)
        {
            double temporary = a;
            a = b;
            b = temporary;
        }

        double result;
        double resultRem;

        Console.WriteLine();
        while (true)
        {
            result = a / b;
            resultRem = a % b;
            if (resultRem != 0)
            {
                Console.WriteLine("{0} : {1} = {2} ; reminder = {3}", a, b, result, resultRem);
                a = b;
                b = resultRem;
            }
            else
            {
                Console.WriteLine("The Greatest Common Divider is: {0}", b);
                break;
            }
        }
    }
}
