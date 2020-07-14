using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Tweet
    {
        // Field
        private static int CURRENT_ID = 0; // Set the id for the first tweet to 0

        // Read-only properties
        public string From { get; }
        public string To { get; }
        public string Body { get; }
        public string Tag { get; }
        public string Id { get; }

        // Constructor 1 used to create tweet
        public Tweet(string fromUser, string to, string body, string tag)
        {
            From = fromUser;
            To = to;
            Body = body;
            Tag = tag;

            // Use the field CURRENT_ID set a unique id
            Id = $"{CURRENT_ID}";
            // Increment CURRENT_ID so the next id will be unique also
            CURRENT_ID++;
        }

        // Contructor 2 for use by the parse method
        public Tweet(string fromUser, string to, string body, string tag, string id)
        {
            From = fromUser;
            To = to;
            Body = body;
            Tag = tag;
            // Special ID to differentiaite it from the normal tweet IDs
            // Otherwise multiple tweets could end up with the same ID
            Id = "s" + id;
        }

        // Return string representation of tweet
        public override string ToString()
        {
            // Ternary operator for printing body
            // Displays full message if <= 40 char 
            // Otherwise just displays first 40 char
            string msg = Body.Length <= 40 ? Body : Body.Substring(0, 40) + "...";
            return $"From: {From}, To: {To}, Message: {msg}, Tag: {Tag}, ID: {Id}";
        }

        // Parses a string to create a tweet object
        public static Tweet Parse(string line)
        {
            // Splits the line on tabs and adds it to the array
            string[] values = line.Split(new string[] { "\\t" }, StringSplitOptions.None);

            // Creates a new tweet object
            Tweet result = new Tweet(values[0], values[1], values[2], values[3], values[4]);
            return result;
        }
    }
}