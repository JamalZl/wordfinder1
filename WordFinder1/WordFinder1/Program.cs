using System;

namespace WordFinder1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello world how are you";
            string word = "are";
            Console.WriteLine(str.Find(word));
        }
    }
}
