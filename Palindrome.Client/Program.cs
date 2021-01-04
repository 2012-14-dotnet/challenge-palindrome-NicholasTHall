using System;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Challenge myword = new Challenge();

            myword.word = Console.ReadLine();

            Console.WriteLine(myword.IsPalindrome());
        }
    }
}
