using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_2
{
    public static class TweetManager
    {
        // Collection of all tweets
        private static List<Tweet> TWEETS;
        // File with tweets
        private static string FILENAME = "Tweets_Assignment_02.txt";

        static TweetManager()
        {
            // Initialize an empty list of tweets
            TWEETS = new List<Tweet>();
            
            // Open file and read first line
            TextReader reader = new StreamReader(FILENAME);
            string input = reader.ReadLine();
            
            // Loop through file to read and parse
            while (input != null)
            {
                // Create tweet and add to TWEETS
                Tweet createdTweet = Tweet.Parse(input);
                TWEETS.Add(createdTweet);

                // Read next line
                input = reader.ReadLine();
            }
            // When there is nothing more, close the file
            reader.Close();
        }

        // Create 5 new tweets to add to list
        // This method will not be used in production, just testing and development
        public static void Initialize()
        {
            TWEETS.Add(new Tweet("a1", "b1", "body of tweet-1", "#happy"));
            TWEETS.Add(new Tweet("a2", "b2", "body of tweet-2", "#happy"));
            TWEETS.Add(new Tweet("a3", "b3", "body of tweet-3", "#happy"));
            TWEETS.Add(new Tweet("a4", "b4", "body of tweet-4", "#happy"));
            TWEETS.Add(new Tweet("a5", "b5", "body of tweet-5", "#happy"));
        }

        // Prints all of the tweets in TWEETS list
        public static void ShowAll()
        {
            foreach (Tweet t in TWEETS)
            {
                Console.WriteLine(t);
            }

            if (TWEETS.Count == 0)
            {
                Console.WriteLine("There are no tweets...");
            }
        }

        // Prints all tweets with a certain tag
        // Method overloading
        public static void ShowAll(string tag)
        {
            // flag is no tweets with the specified tag
            bool flag = false;

            foreach (Tweet t in TWEETS)
            {
                if (t.Tag == tag)
                {
                    Console.WriteLine(t);
                    flag = true;
                }
            }

            // call if no tweets with specified tag
            if (flag == false)
            {
                Console.WriteLine("There are no tweets...");
            }
        }

        // Creates a tweet and adds it to TWEETS
        public static void CreateTweet(string _fromUser, string _to, string _body, string _tag)
        {
            TWEETS.Add(new Tweet(_fromUser, _to, _body, _tag));
        }
    }
}