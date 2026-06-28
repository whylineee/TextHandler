using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using TextHandler.Core;

namespace TextHandler.Plugins
{
    public class MostUsedWordsPlugin : ITextAnalyzePlugin
    {
        public string Name => "Most Used Words Plugin";
        public string Description => "This plugin finds the top 5 most frequently used words (longer than 2 characters).";

        private List<KeyValuePair<string, int>> _topWords = new List<KeyValuePair<string, int>>();

        public void Analyze(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                _topWords.Clear();
                return;
            }

            // Очищаємо текст від розділових знаків і переводимо в нижній регістр
            string cleanText = Regex.Replace(text.ToLower(), @"[^\w\s]", " ");

            char[] delimiters = new char[] { ' ', '\n', '\r', '\t' };
            string[] words = cleanText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // Групуємо слова довжиною > 2, сортуємо за частотою і беремо топ-5
            _topWords = words
                .Where(word => word.Length > 2)
                .GroupBy(word => word)
                .Select(group => new KeyValuePair<string, int>(group.Key, group.Count()))
                .OrderByDescending(pair => pair.Value) // Оптимізація: сортуємо вже пораховані значення
                .Take(5)
                .ToList();
        }

        public void PrintResult()
        {
            Console.WriteLine("Top 5 most used words:");

            if (_topWords != null && _topWords.Count > 0)
            {
                int rank = 1;
                foreach (var pair in _topWords)
                {
                    Console.WriteLine($"{rank}. \"{pair.Key}\" — used {pair.Value} time(s)");
                    rank++;
                }
            }
            else
            {
                Console.WriteLine("No words longer than 2 characters found.");
            }
        }
    }
}