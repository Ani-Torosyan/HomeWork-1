using System;

namespace HomeWork_1
{
    internal class Exc1
    {
        static void Main(string[] args)
        {
            Console.Write("Input the temperature in Celsius: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if(temp <= 0 && temp >= -40) 
            {
                Console.WriteLine("It is freezing!");
            }
            else if (temp >= 0 && temp <= 20)
            {
                Console.WriteLine("It is chilly outside!");
            }
            else if(temp >= 20 && temp <= 40)
            {
                Console.WriteLine("It is really hot!");
            }
            else
            {
                Console.WriteLine("You are going to die...");
            }
        }

    }
}
