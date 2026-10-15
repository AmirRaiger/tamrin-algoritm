using System;

class Program
{
    static int FindMin(int[] A)
    {
        int min = A[0];
        for (int i = 1; i < A.Length; i++)
        {
            if (A[i] < min)
            {
                min = A[i];
            }
        }
        return min;
    }

    static int CountX(int[] A, int x)
    {
        int count = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == x)
            {
                count++;
            }
        }
        return count;
    }

    static int SumEven(int[] A)
    {
        int sum = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] % 2 == 0)
            {
                sum += A[i];
            }
        }
        return sum;
    }

    static void Test(string name, int expected, int actual)
    {
        if (expected == actual)
            Console.WriteLine("PASS: " + name);
        else
            Console.WriteLine("FAIL: " + name + " (expected " + expected + ", got " + actual + ")");
    }

    static void Main()
    {
        // Min
        Test("Min 1", 1, FindMin(new int[] { 5, 3, 1, 4 }));
        Test("Min 2 (single element)", 7, FindMin(new int[] { 7 }));
        Test("Min 3 (negative)", -9, FindMin(new int[] { 0, -9, 3, -2 }));
        Test("Min 4 (all equal)", 2, FindMin(new int[] { 2, 2, 2 }));

        // Count
        Test("Count 1", 3, CountX(new int[] { 1, 2, 1, 3, 1 }, 1));
        Test("Count 2 (not found)", 0, CountX(new int[] { 1, 2, 3 }, 9));
        Test("Count 3 (empty)", 0, CountX(new int[] { }, 5));
        Test("Count 4 (all equal)", 4, CountX(new int[] { 6, 6, 6, 6 }, 6));

        // Sum of evens
        Test("Sum 1", 12, SumEven(new int[] { 1, 2, 3, 4, 5, 6 }));
        Test("Sum 2 (empty)", 0, SumEven(new int[] { }));
        Test("Sum 3 (only odd)", 0, SumEven(new int[] { 1, 3, 5 }));
        Test("Sum 4 (negative and zero)", -6, SumEven(new int[] { -4, -2, 0, 3 }));
    }
}