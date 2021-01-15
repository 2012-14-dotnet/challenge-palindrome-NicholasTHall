using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            UserView();
        }
        static void UserView()
        {
            Challenge myword = new Challenge();

            myword.word = Console.ReadLine();

            Console.WriteLine(myword.IsPalindrome());
        }
    }
}
