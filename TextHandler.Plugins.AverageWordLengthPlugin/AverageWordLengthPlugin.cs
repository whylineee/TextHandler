using TextHandler.Core;

namespace TextHandler.Plugins.AverageWordLengthPlugin;

public class AverageWordLengthPlugin : ITextAnalyzePlugin
{
    private double averageLength;

    public string Name => "Average Word Length";

    public string Description =>
        "Calculates the average word length.";

    public void Analyze(string text)
    {
        string[] words = text.Split(
            [' ', '\n', '\r', '\t', '.', ',', '!', '?', ':', ';', '-', '(', ')'],
            StringSplitOptions.RemoveEmptyEntries);

        if (words.Length == 0)
        {
            averageLength = 0;
            return;
        }

        int sum = 0;

        foreach (string word in words)
        {
            sum += word.Length;
        }

        averageLength = (double)sum / words.Length;
    }

    public void PrintResult()
    {
        Console.WriteLine($"Average word length: {averageLength:F2}");
    }
}