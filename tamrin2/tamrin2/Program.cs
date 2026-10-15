using System;

class Program
{
    static void Main()
    {
        int[] A = { 2, 5, 2, 7, 2 };
        int x = 2;
        int count = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == x)
            {
                count++;
            }
        }

        Console.WriteLine("Count = " + count);
    }
}