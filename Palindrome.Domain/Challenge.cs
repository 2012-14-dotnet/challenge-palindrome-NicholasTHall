namespace Palindrome.Domain
{
    class Challenge
    {
        public string word {get; set;}

        Challenge(){}
        Challenge(string userWord)
        {
            word = userWord;
        }
        public bool IsPalindrome()
        {
            var sb = new StringBuilder();

            string test = word.Replace(" ", "");

            for(int i=test.Length;i>0;i--)
            {
                sb.Append(test.Substring(i-1,1));
            }

            return test.Equals(sb);     
        }
    }
}