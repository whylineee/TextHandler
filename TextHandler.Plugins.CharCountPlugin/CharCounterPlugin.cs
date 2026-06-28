using System;
using System.Linq;
using TextHandler.Core;

namespace TextHandler.Plugins
{
    public class CharCounterPlugin : ITextAnalyzePlugin
    {
        public string Name => "Char Counter Plugin";
        public string Description => "This plugin counts the total number of characters with and without spaces.";

        private int _totalCharsWithSpaces = 0;
        private int _totalCharsNoSpaces = 0;

        public void Analyze(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                _totalCharsWithSpaces = 0;
                _totalCharsNoSpaces = 0;
                return;
            }

            // Рахуємо всі символи, які є в тексті
            _totalCharsWithSpaces = text.Length;

            // Більш ефективний підрахунок символів без пробілів та службових знаків за допомогою LINQ
            _totalCharsNoSpaces = text.Count(c => c != ' ' && c != '\r' && c != '\n' && c != '\t');
        }

        public void PrintResult()
        {
            if (_totalCharsWithSpaces > 0)
            {
                Console.WriteLine($"Total characters (with spaces): {_totalCharsWithSpaces}");
                Console.WriteLine($"Total characters (without spaces): {_totalCharsNoSpaces}");
            }
            else
            {
                Console.WriteLine("No characters found to analyze.");
            }
        }
    }
}