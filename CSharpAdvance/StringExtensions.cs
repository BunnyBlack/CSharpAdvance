using System;
using System.Linq;

namespace CSharpAdvance
{
    public static class StringExtensions
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numberOfWords));
            }
            
            if (numberOfWords == 0)
            {
                return "";
            }
            
            var words = str.Split(' ');
            if (words.Length <= numberOfWords)
            {
                return str;
            }

            var shorten = string.Join(" ", words.Take(numberOfWords));
            return $"{shorten}...";
        }
    }
}