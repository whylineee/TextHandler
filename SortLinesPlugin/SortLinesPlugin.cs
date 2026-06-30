using System.Globalization;
using TextHandler.Core;

namespace TextHandler.Plugins
{
    public class SortLinesPlugin : ITextAnalyzePlugin
    {
        public string Name => "Sort Lines Plugin";
        public string Description => "This plugin sorts text lines alphabetically with Ukrainian culture support.";

        private string _processedText = string.Empty;

        public void Analyze(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                _processedText = string.Empty;
                return;
            }

            var lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            var culture = new CultureInfo("uk-UA");
            var comparer = StringComparer.Create(culture, ignoreCase: true);

            var sortedLines = lines.OrderBy(line => line, comparer);

            _processedText = string.Join(Environment.NewLine, sortedLines);
        }

        public void PrintResult()
        {
            if (!string.IsNullOrEmpty(_processedText))
            {
                Console.WriteLine("Sorted lines:");
                Console.WriteLine(_processedText);
            }
            else
            {
                Console.WriteLine("No lines found to sort.");
            }
        }
    }
}
// o