using System;

namespace HomeWork_1
{
    internal class Exc7
    {
        static void Main(string[] args)
        {
            int[] firstArr = { 1, 2, 3 };
            int[] secondArr = { 4, 5, 6 };
            int len = firstArr.Length;

            if (len != secondArr.Length)
            {
                Console.WriteLine("The arrays aren't of the same size!");
                return;
            }
            else
            {
                int[] sumArr = new int[len];

                for (int i = 0; i < len; i++)
                {
                    sumArr[i] = firstArr[i] + secondArr[i];
                    Console.Write(firstArr[i] + secondArr[i] + " ");
                }
            }
        }
    }
}
