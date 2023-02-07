using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsPass = int.Parse(Console.ReadLine());

            var cars = new Queue<string>();

            int countCarsPassed = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                else if (command == "green")
                {
                    if (carsPass > cars.Count)
                    {
                        carsPass = cars.Count;
                    }
                    for (int i = 0; i < carsPass; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        countCarsPassed++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }
            Console.WriteLine($"{countCarsPassed} cars passed the crossroads.");
        }
    }
}
