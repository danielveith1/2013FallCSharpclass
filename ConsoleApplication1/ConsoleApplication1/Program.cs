using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ConsoleApplication1
{
    public class Program
    {
        public delegate int Multiply(int x, int y);
        
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");
            System.Console.ReadLine();
            System.Console.WriteLine("What is your username?");
            string response = System.Console.ReadLine();



            System.Console.WriteLine("Here's your profile info");
            System.Console.Write(GetProfile(response));
            System.Console.ReadLine();
        }
        public static string GetProfile(string username)
        {
            var client = new HttpClient();

            var json = client.GetStringAsync("http://graph.facebook.com/" + username).Result;
            return json;
        }
    }
        public class Dog
        {
            private List<string> _ListOfWords = new List<string>();
            private string _DogsWord = "woof";

            public string DogsWord 
            {
                get
                {
                    return _DogsWord;
                }
                set
                {
                    _DogsWord = value;
                }
            }

            public string Bark()
            {
                return _DogsWord + " " + string.Join(", ", _ListOfWords);
            }
            public void LearnNewWord(string word)
            {
                _ListOfWords.Add(word);

  
            }
            [Obsolete]
            public string Run()
            {
                return "I am running at " + Speed + " Miles an Hour";
            }

            public string Speed { get; set; }
        }
    
}
