using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songNames = Console.ReadLine().Split(", ").ToArray();
            string command = Console.ReadLine();

            Queue<string> songs = new Queue<string>(songNames);
            while(songs.Count > 0)
            {
                string[] splitter = command.Split();
                switch(splitter[0])
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string combinedSong = string.Join(" ", splitter.Skip(1));
                        if (songs.Contains(combinedSong))
                        {
                            Console.WriteLine($"{combinedSong} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(combinedSong);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
