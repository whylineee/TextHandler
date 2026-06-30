using System.Text.RegularExpressions;
using TextHandler.Core;

namespace TextHandler.Plugins
{
    public class RemoveExtraSpacesPlugin : ITextAnalyzePlugin
    {
        public string Name => "Remove Extra Spaces Plugin";
        public string Description => "This plugin removes leading, trailing, and duplicate spaces from each line.";

        private string _processedText = string.Empty;

        public void Analyze(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                _processedText = string.Empty;
                return;
            }

            var lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            var cleanedLines = lines.Select(line =>
            {
                var trimmed = line.Trim();
                return Regex.Replace(trimmed, @"[ \t]+", " ");
            });

            _processedText = string.Join(Environment.NewLine, cleanedLines);
        }

        public void PrintResult()
        {
            if (!string.IsNullOrEmpty(_processedText))
            {
                Console.WriteLine("Text after removing extra spaces:");
                Console.WriteLine(_processedText);
            }
            else
            {
                Console.WriteLine("No text found or the text is empty.");
            }
        }
    }
}