using TextHandler.Core;

namespace TextHandler.Plugins.ShortestWordPlugin
{
    public class ShortestWordPlugin : ITextAnalyzePlugin
    {
        private string shortestWord = "";

        public string Name => "Shortest Word";

        public string Description =>
            "Finds the shortest word.";

        public void Analyze(string text)
        {
            string[] words = text.Split(
                [' ', '\n', '\r', '\t', '.', ',', '!', '?', ':', ';', '-', '(', ')'],
                StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                shortestWord = "";
                return;
            }

            shortestWord = words[0];

            foreach (string word in words)
            {
                if (word.Length < shortestWord.Length)
                {
                    shortestWord = word;
                }
            }
        }

        public void PrintResult()
        {
            Console.WriteLine($"Shortest word: {shortestWord}");
        }
    }
}
