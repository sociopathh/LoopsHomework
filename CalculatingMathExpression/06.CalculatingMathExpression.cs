/* Task 6
* Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN*/

using System;

class CalculatingMathExpression
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number X: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        double nFactorial = 1;
        double poweredX;

        for (int i = 1; i <= n; i++)
        {
            poweredX = (int)Math.Pow(x, i);
            nFactorial *= i;
            sum += nFactorial / poweredX;
        }
        Console.WriteLine(sum);
    }
}
