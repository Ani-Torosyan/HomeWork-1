using System;

namespace HomeWork_1
{
    internal class Exc2
    {
        static void Main(string[] args)
        {
            Console.Write("Input your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            while (age < 0)
            {
                Console.WriteLine("Wrong input.");
                Console.Write("Input your age: ");
                age = Convert.ToInt32(Console.ReadLine());
            }

            if (age < 13)
            {
                Console.WriteLine("You are a child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a teen");
            }
            else
            {
                Console.WriteLine("You are an adult");
            }

        }
    }
}
