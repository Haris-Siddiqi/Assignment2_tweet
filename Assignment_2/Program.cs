using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's test!
            // Are there any tweets currently?
            Console.WriteLine("Tweets from file:");
            TweetManager.ShowAll();
            Console.WriteLine();
            // Yes, the tweets that were initialized from the file

            // Let's create 3 tweets
            // We will only use the CreateTweet method to create tweets because it automatically adds them to the tweet manager
            // and keeps the current_id icrementing properly
            TweetManager.CreateTweet("Imtiaj", "Thiago", "Hey man! working on programming 2 assignment today?", "#ready");
            TweetManager.CreateTweet("Haris", "Thiago", "yea bro stop being lazy lets do it", "#ready");
            TweetManager.CreateTweet("Thiago", "Haris", "just making my coffee here, then im ready", "#coffeeislife");

            // Let's see the tweets
            Console.WriteLine("Updated list:");
            TweetManager.ShowAll();
            Console.WriteLine();

            // Let's test the initialize method
            TweetManager.Initialize();
            Console.WriteLine("Updated list:");
            TweetManager.ShowAll();
            Console.WriteLine();

            // Let's show just the tweets with a certain hash tag
            Console.WriteLine("#ready");
            TweetManager.ShowAll("#ready");
            Console.WriteLine();
            Console.WriteLine("#none");
            TweetManager.ShowAll("#none");
            Console.WriteLine();
            Console.WriteLine("#happy");
            TweetManager.ShowAll("#happy");
            Console.WriteLine();
            Console.WriteLine("#blessed");
            TweetManager.ShowAll("#blessed");
        }
    }
}
