using System;

namespace HomeWork_1
{
    internal class Exc3
    {
        static void Main(string[] args)
        {
            Console.Write("Input the temperature: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            char tempType;
            do
            {
                Console.Write("Is it celsius(C) or Fahrenheit(F): ");
                tempType = char.ToUpper(Convert.ToChar(Console.ReadKey().KeyChar));

                if (tempType != 'C' && tempType != 'F')
                {
                    Console.WriteLine("\nWrong input!");
                }
            } 
            while (tempType != 'C' && tempType != 'F');

            if (tempType == 'C')
            {
                Console.WriteLine("\nThe temp in F is: " + (temp * 9/5 +32));
            }
            else Console.WriteLine("\nThe temp in C is: " + ((temp - 32) * 5/9));
        }
    }
}
