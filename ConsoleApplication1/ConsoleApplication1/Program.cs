using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your user name?");
            var name = Console.ReadLine();
            Console.Write(GetUserInfo(name));
            Console.ReadLine();
        }

        public static string GetUserInfo(string name)
        {
            var web = new HttpClient();
            return web.GetStringAsync("http://graph.facebook.com/" + name).Result;
        }
    }

    public delegate int Multiply(int x, int y);

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
        public string Speed { get; set; }

        public string Bark()
        {
            return _DogsWord + string.Join(", ", _ListOfWords);
        }

        public void LearnNewWord(string word)
        {
            _ListOfWords.Add(word);
        }

        public string Run()
        {
            return "I am running at " + Speed + " Miles an Hour";
        }

    }
}
