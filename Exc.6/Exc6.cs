using System;

namespace HomeWork_1
{
    internal class Exc6
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int max = arr[0], ind = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    ind = i;
                }
            }

            max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max && i != ind)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("The second max is: " + max);
        }
    }
}
