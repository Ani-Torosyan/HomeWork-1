using System;

namespace HomeWork_1
{
    internal class Exc5
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 }, temp = new int[arr.Length];
            int j = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                temp[j] = arr[i];
                j++;
            }

            arr = temp;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
