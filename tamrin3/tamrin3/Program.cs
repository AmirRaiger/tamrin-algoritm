using System;

class Program
{
    static void Main()
    {
        int[] A = { 1, 4, 6, 3, 8, 5 };
        int sum = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] % 2 == 0)
            {
                sum += A[i];
            }
        }

        Console.WriteLine("Sum = " + sum);
    }
}