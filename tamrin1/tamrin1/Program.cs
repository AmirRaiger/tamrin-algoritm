
using System;

class Program
{
    static void Main()
    {
        int[] A = { 8, 3, 12, -2, 5 };

        int min = A[0];

        for (int i = 1; i < A.Length; i++)
        {
            if (A[i] < min)
            {
                min = A[i];
            }
        }

        Console.WriteLine("Minimum = " + min);
    }
}
