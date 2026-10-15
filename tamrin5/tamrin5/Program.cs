using System;

class Program
{
    static void Main()
    {
        int[] A = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };

        int x = 23;

        int linearIndex = -1;
        int linearCount = 0;

        for (int i = 0; i < A.Length; i++)
        {
            linearCount++;
            if (A[i] == x)
            {
                linearIndex = i;
                break;
            }
        }

        Console.WriteLine("Linear Search:");
        Console.WriteLine("Index = " + linearIndex);
        Console.WriteLine("Comparisons = " + linearCount);
        Console.WriteLine();

        int low = 0;
        int high = A.Length - 1;
        int binaryIndex = -1;
        int binaryCount = 0;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            binaryCount++;

            if (A[mid] == x)
            {
                binaryIndex = mid;
                break;
            }
            else if (A[mid] < x)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        Console.WriteLine("Binary Search:");
        Console.WriteLine("Index = " + binaryIndex);
        Console.WriteLine("Comparisons = " + binaryCount);
    }
}