using System;
using System.Linq;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSongs = Console.ReadLine().Split(", ");

            var songs = new Queue<string>(firstSongs);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Play")
                {
                    if (songs.Count > 1)
                    {
                        songs.Dequeue();
                    }
                    else
                    {
                        break;
                    }
                }
                else if (input == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
                else 
                {
                    string[] splitsInTwo = input.Split(' ' , 2);
                    if (splitsInTwo[0] == "Add")
                    {
                        var songName = splitsInTwo[1];
                        if (!songs.Contains(songName))
                        {
                            songs.Enqueue(songName);
                        }
                        else
                        {
                            Console.WriteLine($"{songName} is already contained!");
                        }
                    }
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
