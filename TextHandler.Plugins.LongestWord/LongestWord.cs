using System;
using System.Linq;
using TextHandler.Core;

namespace TextHandler.Plugins
{
    public class LongestWord : ITextAnalyzePlugin
    {
        public string Name => "Longest Word Finder";
        public string Description => "Finds and displays the longest word and its length";

        private string longestWord = string.Empty;
        private int longestWordLength = 0;

        public void Analyze(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                longestWord = string.Empty;
                longestWordLength = 0;
                return;
            }

            char[] delimiters = new char[] { ' ', '.', ',', '!', '?', ';', ':', '-', '\n', '\r', '\t' };
            string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > 0)
            {
                longestWord = words.OrderByDescending(w => w.Length).First();
                longestWordLength = longestWord.Length;
            }
            else
            {
                longestWord = string.Empty;
                longestWordLength = 0;
            }
        }

        public void PrintResult()
        {
            if (longestWordLength > 0)
            {
                Console.WriteLine($"Longest Word: \"{longestWord}\"");
                Console.WriteLine($"Character Count: {longestWordLength}");
            }
            else
            {
                Console.WriteLine("No words were found to analyze");
            }
        }
    }
}