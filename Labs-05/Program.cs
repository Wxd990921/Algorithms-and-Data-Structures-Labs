using System;
using System.Collections.Generic;

public class PlaylistApp
{
    public static void Main(string[] args)
    {
        LinkedList<string> playlist = new LinkedList<string>();
        Stack<string> history = new Stack<string>();
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a song to your playlist");
            Console.WriteLine("2. Play the next song in your playlist");
            Console.WriteLine("3. Skip the next song");
            Console.WriteLine("4. Rewind one song");
            Console.WriteLine("5. Exit");
            string input = Console.ReadLine();
            if (input.Equals("1"))
            {
                Console.WriteLine("Enter Song Name:");
                string song = Console.ReadLine();
                playlist.AddLast(song);
                Console.WriteLine($"{song} added to your playlist.");
            }
            else if (input.Equals("2"))
            {
                if (playlist.Count > 0)
                {
                    string song = playlist.First.Value;
                    playlist.RemoveFirst();
                    history.Push(song);
                    Console.WriteLine($"Now playing {song}");
                    if (playlist.Count > 0)
                    {
                        Console.WriteLine($"Next song: {playlist.First.Value}");
                    }
                    else
                    {
                        Console.WriteLine("Next song: none queued");
                    }
                }
                else
                {
                    Console.WriteLine("Your playlist is empty.");
                }
            }
            else if (input.Equals("3"))
            {
                if (playlist.Count > 0)
                {
                    string song = playlist.First.Value;
                    playlist.RemoveFirst();
                    Console.WriteLine($"Skipped {song}");
                    if (playlist.Count > 0)
                    {
                        Console.WriteLine($"Next song: {playlist.First.Value}");
                    }
                    else
                    {
                        Console.WriteLine("Next song: none queued");
                    }
                }
                else
                {
                    Console.WriteLine("Your playlist is empty.");
                }
            }
            else if (input.Equals("4"))
            {
                if (history.Count > 0)
                {
                    string song = history.Pop();
                    playlist.AddFirst(song);
                    Console.WriteLine($"Rewound to {song}");
                    if (playlist.Count > 0)
                    {
                        Console.WriteLine($"Next song: {playlist.First.Value}");
                    }
                    else
                    {
                        Console.WriteLine("Next song: none queued");
                    }
                }
                else
                {
                    Console.WriteLine("You haven't played any songs yet.");
                }
            }
            else if (input.Equals("5"))
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}