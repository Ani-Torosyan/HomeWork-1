using System;

namespace HomeWork_1
{
    internal class Exc4
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min) 
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("The max is: " + max);
            Console.WriteLine("The min is: " + min);
        }       
    }
}
