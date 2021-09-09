namespace Algorithms.Recursive
{
    public class Reverse
    {
        private static string _result = "";

        public static string ReverseChars(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                _result += "";
            }
            else
            {
                _result += word[^1];
                ReverseChars(word.Substring(0, word.Length - 1));
            }

            return _result;
        }
    }
}